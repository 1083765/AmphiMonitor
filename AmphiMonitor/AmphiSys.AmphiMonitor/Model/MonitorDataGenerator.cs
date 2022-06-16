using AmphiSys.Monitor.MonitorDataModel;
using System;

namespace AmphiSys.AmphiMonitor.Model
{
    public class MonitorDataGenerator
    {
        MonitorDataContainer _monitorDataContainer;

        // Constuct a MonitorDataGenerator object.
        /// <summary>
        /// Constuct a MonitorDataGenerator object and gets instance of MonitorDataContainer.
        /// </summary>
        public MonitorDataGenerator()
        {
            _monitorDataContainer = MonitorDataContainer.GetInstance();
        }

        // Generate a HeartRate object.
        /// <summary>
        /// Generate and return a HeartRate object with random parameters,
        /// based on patient type.
        /// </summary>
        /// <returns>
        /// A heart rate object.
        /// </returns>
        /// <param name="patientType">Type of patient.</param>
        public HeartRate GenerateHeartRate(int patientType)
        {
            int beatsPerMinute = 0;
            DateTime timeOfDataCreation = new DateTime();

            beatsPerMinute = GenerateBeatsPerMinute(patientType);
            timeOfDataCreation = GeneratetimeOfDataCreation();

            HeartRate heartRate = new HeartRate(beatsPerMinute, timeOfDataCreation);

            _monitorDataContainer.HeartRate = heartRate;

            return heartRate;
        }

        // Generate a NIBP object.
        /// <summary>
        /// Generate and return a NIBP object with random parameters,
        /// based on patient type.
        /// </summary>
        /// <returns>
        /// A NIBP object.
        /// </returns>
        /// <param name="patientType">Type of patient.</param>
        public NIBP GenerateNIBP(int patientType)
        {
            int systolic = 0;
            int diastolic = 0;
            int meanArterialPressure = 0;
            DateTime timeOfDataCreation = new DateTime();

            systolic = GenerateSystolic(patientType);
            diastolic = GenerateDiastolic(patientType);
            meanArterialPressure = GenerateMeanArterialPressure(systolic, diastolic);
            timeOfDataCreation = GeneratetimeOfDataCreation();

            NIBP nIBP = new NIBP(systolic, diastolic, meanArterialPressure, timeOfDataCreation);

            _monitorDataContainer.NIBP = nIBP;

            return nIBP;
        }

        // Generate a IBP object.
        /// <summary>
        /// Generate and return a IBP object with random parameters,
        /// based on patient type.
        /// </summary>
        /// <returns>
        /// A IBP object.
        /// </returns>
        /// <param name="patientType">Type of patient.</param>
        public IBP GenerateIBP(int patientType)
        {
            int systolic = 0;
            int diastolic = 0;
            int meanArterialPressure = 0;
            DateTime timeOfDataCreation = new DateTime();

            systolic = GenerateSystolic(patientType);
            diastolic = GenerateDiastolic(patientType);
            meanArterialPressure = GenerateMeanArterialPressure(systolic, diastolic);
            timeOfDataCreation = GeneratetimeOfDataCreation();

            IBP iBP = new IBP(systolic, diastolic, meanArterialPressure, timeOfDataCreation);

            _monitorDataContainer.IBP = iBP;

            return iBP;
        }

        // Generate a SpO2 object.
        /// <summary>
        /// Generate and return a SpO2 object with random parameters,
        /// based on patient type.
        /// </summary>
        /// <returns>
        /// A SpO2 object.
        /// </returns>
        /// <param name="patientType">Type of patient.</param>
        public SpO2 GenerateSpO2(int patientType)
        {
            int satuation = 0;
            DateTime timeOfDataCreation = new DateTime();

            satuation = GenerateSpO2Saturation(patientType);
            timeOfDataCreation = GeneratetimeOfDataCreation();

            SpO2 spO2 = new SpO2(satuation, timeOfDataCreation);

            _monitorDataContainer.SpO2 = spO2;

            return spO2;
        }

        // Generate a Pulse object.
        /// <summary>
        /// Generate and return a Pulse object with random parameters,
        /// based on patient type.
        /// </summary>
        /// <returns>
        /// A Pulse object.
        /// </returns>
        /// <param name="patientType">Type of patient.</param>
        public Pulse GeneratePulse(int patientType)
        {
            int beatsPerMinute = 0;
            DateTime timeOfDataCreation = new DateTime();

            beatsPerMinute = GenerateBeatsPerMinute(patientType);
            timeOfDataCreation = GeneratetimeOfDataCreation();

            Pulse pulse = new Pulse(beatsPerMinute, timeOfDataCreation);

            _monitorDataContainer.Pulse = pulse;

            return pulse;
        }

        // Generate a CO2 object.
        /// <summary>
        /// Generate and return a CO2 object with random parameters,
        /// based on patient type.
        /// </summary>
        /// <returns>
        /// A CO2 object.
        /// </returns>
        /// <param name="patientType">Type of patient.</param>
        public CO2 GenerateCO2(int patientType)
        {
            int concentration = 0;
            DateTime timeOfDataCreation = new DateTime();

            concentration = GenerateCO2Concentration(patientType);
            timeOfDataCreation = GeneratetimeOfDataCreation();

            CO2 cO2 = new CO2(concentration, timeOfDataCreation);

            _monitorDataContainer.CO2 = cO2;

            return cO2;
        }

        // Generate a RespiratoryRate object.
        /// <summary>
        /// Generate and return a RespiratoryRate object with random parameters,
        /// based on patient type.
        /// </summary>
        /// <returns>
        /// A RespiratoryRate object.
        /// </returns>
        /// <param name="patientType">Type of patient.</param>
        public RespiratoryRate GenerateRespiratoryRate(int patientType)
        {
            int breathsPerMinute = 0;
            DateTime timeOfDataCreation = new DateTime();

            breathsPerMinute = GenerateBreathsPerMinute(patientType);
            timeOfDataCreation = GeneratetimeOfDataCreation();

            RespiratoryRate respirationRate = new RespiratoryRate(breathsPerMinute, timeOfDataCreation);

            _monitorDataContainer.RespiratoryRate = respirationRate;

            return respirationRate;
        }

        // Generate a Temperature object.
        /// <summary>
        /// Generate and return a Temperature object with random parameters,
        /// based on patient type.
        /// </summary>
        /// <returns>
        /// A Temperature object.
        /// </returns>
        /// <param name="patientType">Type of patient.</param>
        public Temperature GenerateTemperature(int patientType)
        {
            double degrees = 0;
            DateTime timeOfDataCreation = new DateTime();

            degrees = GenerateTemperatureDegrees(patientType);
            timeOfDataCreation = GeneratetimeOfDataCreation();

            Temperature temperature = new Temperature(degrees, timeOfDataCreation);

            _monitorDataContainer.Temperature = temperature;

            return temperature;
        }

        // Generate a MonitorEvent object.
        /// <summary>
        /// Generate and return a MonitorEvent object with random parameters,
        /// based on patient type.
        /// </summary>
        /// <returns>
        /// A MonitorEvent object.
        /// </returns>
        /// <param name="patientType">Type of patient.</param>
        public MonitorEvent GenerateMonitorEvent()
        {
            DateTime timeOfDataCreation = new DateTime();

            timeOfDataCreation = GeneratetimeOfDataCreation();

            MonitorEvent monitorEvent = new MonitorEvent(timeOfDataCreation);

            _monitorDataContainer.MonitorEvents.Add(monitorEvent);

            return monitorEvent;
        }

        // Generate random data for Spo2.
        /// <summary>
        /// Generate random data for Spo2 saturation based on patient type.
        /// </summary>
        /// <returns>
        /// A integer number.
        /// </returns>
        /// <param name="patientType">Type of patient</param>
        public int GenerateSpO2Saturation(int patientType)
        {
            int satuation = 0;
            int minSaturation = 0;
            int maxSaturation = 0;

            switch (patientType)
            {
                //Generate SpO2 based on healthy and stroke patient.
                case 0:
                case 1:
                    minSaturation = 97;
                    maxSaturation = 100;
                    break;
                //Generate SpO2 based on COPD patient.
                case 2:
                    minSaturation = 88;
                    maxSaturation = 91;
                    break;
                //Generate SpO2 based on COVID-19 patient.
                default:
                    minSaturation = 90;
                    maxSaturation = 93;
                    break;
            }

            satuation = new Random().Next(minSaturation, maxSaturation);

            return satuation;
        }

        // Generate random data for heart rate or pulse.
        /// <summary>
        /// Generate random data for heart rate or pulse based on patient type.
        /// </summary>
        /// <returns>
        /// A integer number.
        /// </returns>
        /// <param name="patientType">Type of patient</param>
        public int GenerateBeatsPerMinute(int patientType)
        {
            int beatsPerMinute = 0;
            int minBeatsPerMinute = 0;
            int maxBeatsPerMinute = 0;

            switch (patientType)
            {
                //Generate BeatsPerMinute based on healthy, COPD and COVID-19 patient.
                case 0:
                case 2:
                case 3:
                    minBeatsPerMinute = 59;
                    maxBeatsPerMinute = 62;
                    break;
                //Generate BeatsPerMinute based on stroke patient.
                case 1:
                    minBeatsPerMinute = 82;
                    maxBeatsPerMinute = 85;
                    break;
            }

            beatsPerMinute = new Random().Next(minBeatsPerMinute, maxBeatsPerMinute);

            return beatsPerMinute;
        }

        // Generate random systolic for NIBP or IBP.
        /// <summary>
        /// Generate random systolic for NIBP or IBP based on patient type.
        /// </summary>
        /// <returns>
        /// A integer number.
        /// </returns>
        /// <param name="patientType">Type of patient</param>
        public int GenerateSystolic(int patientType)
        {
            int systolic = 0;
            int minSystolic = 0;
            int maxSystolic = 0;

            switch (patientType)
            {
                //Generate Systolic based on healthy, COPD and COVID-19 patient.
                case 0:
                case 2:
                case 3:
                    minSystolic = 113;
                    maxSystolic = 116;
                    break;
                //Generate Systolic based on stroke patient.
                case 1:
                    minSystolic = 182;
                    maxSystolic = 185;
                    break;
            }

            systolic = new Random().Next(minSystolic, maxSystolic);

            return systolic;
        }

        // Generate random diastolic for NIBP or IBP.
        /// <summary>
        /// Generate random diastolic for NIBP or IBP based on patient type.
        /// </summary>
        /// <returns>
        /// A integer number.
        /// </returns>
        /// <param name="patientType">Type of patient</param>
        public int GenerateDiastolic(int patientType)
        {
            int diastolic = 0;
            int minDiastolic = 0;
            int maxDiastolic = 0;

            switch (patientType)
            {
                //Generate Diastolic based on healthy, COPD and COVID-19 patient.
                case 0:
                case 2:
                case 3:
                    minDiastolic = 79;
                    maxDiastolic = 81;
                    break;
                //Generate Diastolic based on stroke patient.
                case 1:
                    minDiastolic = 109;
                    maxDiastolic = 111;
                    break;
            }

            diastolic = new Random().Next(minDiastolic, maxDiastolic);

            return diastolic;
        }

        // Generate a NIBP or IBP mean arterial pressure.
        /// <summary>
        /// Generate a NIBP or IBP mean arterial pressure from Systolic and Diastolic parametre.
        /// </summary>
        /// <returns>
        /// A integer number.
        /// </returns>
        /// <param name="systolic">Systolic pressure</param>
        /// <param name="diastolic">Diastolic pressure</param>
        public int GenerateMeanArterialPressure(int systolic, int diastolic)
        {
            int meanArterialPressure = 0;

            meanArterialPressure = (((2 * diastolic) + systolic)) / 3;

            return meanArterialPressure;
        }

        // Generate random temperature data.
        /// <summary>
        /// Generate random temperature data based on patient type.
        /// </summary>
        /// <returns>
        /// A double number.
        /// </returns>
        /// <param name="patientType">Type of patient</param>
        public double GenerateTemperatureDegrees(int patientType)
        {
            double degrees = 0;
            double minDegrees = 0;
            double maxDegrees = 0;

            switch (patientType)
            {
                //Generate Degrees based on healthy, stroke and COPD patient.
                case 0:
                case 1:
                case 2:
                    minDegrees = 36.5;
                    maxDegrees = 36.7;
                    break;
                //Generate Degrees based on COVID-19 patient.
                case 3:
                    minDegrees = 37.9;
                    maxDegrees = 38.1;
                    break;
            }

            degrees = new Random().NextDouble() * (maxDegrees - minDegrees) + minDegrees;
            degrees = Math.Round(degrees, 1);

            return degrees;
        }

        // Generate random data for respiratory rate.
        /// <summary>
        /// Generate breaths per minute for respiratory rate based on patient type.
        /// </summary>
        /// <returns>
        /// A integer number.
        /// </returns>
        /// <param name="patientType">Type of patient</param>
        public int GenerateBreathsPerMinute(int patientType)
        {
            int breathsPerMinute = 0;
            int minBreathsPerMinute = 0;
            int maxBreathsPerMinute = 0;

            switch (patientType)
            {
                //Generate Degrees based on healthy and stroke patient.
                case 0:
                case 1:
                    minBreathsPerMinute = 16;
                    maxBreathsPerMinute = 19;
                    break;
                //Generate Degrees based on COPD patient.
                case 2:
                    minBreathsPerMinute = 27;
                    maxBreathsPerMinute = 30;
                    break;
                //Generate Degrees based on COVID-19 patient.
                case 3:
                    minBreathsPerMinute = 25;
                    maxBreathsPerMinute = 28;
                    break;
            }

            breathsPerMinute = new Random().Next(minBreathsPerMinute, maxBreathsPerMinute);

            return breathsPerMinute;
        }

        // Generate random data for CO2.
        /// <summary>
        /// Generate concentration for CO2 based on patient type.
        /// </summary>
        /// <returns>
        /// A integer number.
        /// </returns>
        /// <param name="patientType">Type of patient</param>
        public int GenerateCO2Concentration(int patientType)
        {
            int concentration = 0;
            int minConcentration = 0;
            int maxConcentration = 0;

            switch (patientType)
            {
                //Generate Degrees based on healthy, stroke and COPD patient.
                case 0:
                case 1:
                case 2:
                    minConcentration = 39;
                    maxConcentration = 43;
                    break;
                //Generate Degrees based on COVID-19 patient.
                case 3:
                    minConcentration = 47;
                    maxConcentration = 52;
                    break;
            }

            concentration = new Random().Next(minConcentration, maxConcentration);

            return concentration;
        }

        // Generate a DateTime object.
        /// <summary>
        /// Generate and returns a DateTime object based on the time created.
        /// </summary>
        /// <returns>
        /// A DateTime object.
        /// </returns>
        public DateTime GeneratetimeOfDataCreation()
        {
            DateTime timeOfDataCreation = DateTime.Now;

            return timeOfDataCreation;
        }
    }
}