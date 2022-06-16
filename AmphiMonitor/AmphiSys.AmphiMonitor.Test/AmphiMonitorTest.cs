//using System.Collections.Generic;
//using AmphiSys.AmphiMonitor.BusinessLogic;
//using AmphiSys.Monitor.Measurements;
//using NUnit.Framework;

//namespace AmphiSys.AmphiMonitor.Test
//{
//    public class TestGetAllMeasurements
//    {
//        [Test]
//        public void GetAllMeasurements()
//        {
//            // Arrange
//            MeasurementLogic _measurementLogic = new MeasurementLogic();

//            int patientType = 0;

//            HeartRate HeartRate = _measurementLogic.GenerateHeartRate(patientType);
//            NIBP NIBP = _measurementLogic.GenerateNIBP(patientType);
//            IBP IBP = _measurementLogic.GenerateIBP(patientType);
//            SpO2 SpO2 = _measurementLogic.GenerateSpO2(patientType);
//            Pulse Pulse = _measurementLogic.GeneratePulse(patientType);
//            CO2 CO2 = _measurementLogic.GenerateCO2(patientType);
//            RespiratoryRate RespiratoryRate = _measurementLogic.GenerateRespiratoryRate(patientType);
//            Temperature Temperature = _measurementLogic.GenerateTemperature(patientType);

//            HeartRate ContainerHeartRate = null;
//            NIBP ContainerNIBP = null;
//            IBP ContainerIBP = null;
//            SpO2 ContainerSpO2 = null;
//            Pulse ContainerPulse = null;
//            CO2 ContainerCo2 = null;
//            RespiratoryRate ContainerRespiratoryRate = null;
//            Temperature ContainerTemperature = null;

//            // Act
//            ContainerHeartRate = _measurementLogic.GetHeartRate();
//            ContainerNIBP = _measurementLogic.GetNIBP();
//            ContainerIBP = _measurementLogic.GetIBP();
//            ContainerSpO2 = _measurementLogic.GetSpO2();
//            ContainerPulse = _measurementLogic.GetPulse();
//            ContainerCo2 = _measurementLogic.GetCO2();
//            ContainerRespiratoryRate = _measurementLogic.GetRespiratoryRate();
//            ContainerTemperature = _measurementLogic.GetTemperature();

//            // Assert
//            Assert.AreEqual(HeartRate, ContainerHeartRate);
//            Assert.AreEqual(NIBP, ContainerNIBP);
//            Assert.AreEqual(IBP, ContainerIBP);
//            Assert.AreEqual(SpO2, ContainerSpO2);
//            Assert.AreEqual(Pulse, ContainerPulse);
//            Assert.AreEqual(CO2, ContainerCo2);
//            Assert.AreEqual(RespiratoryRate, ContainerRespiratoryRate);
//            Assert.AreEqual(Temperature, ContainerTemperature);

//        }

//    }


//}
