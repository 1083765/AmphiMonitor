using Microsoft.AspNetCore.Mvc;
using AmphiSys.Monitor.MonitorDataModel;
using AmphiSys.AmphiMonitor.Service.DTO;
using AmphiSys.AmphiMonitor.Service.ModelConversion;
using AmphiSys.AmphiMonitor.Service.BusinessLogic;
using Newtonsoft.Json;

namespace AmphiSys.AmphiMonitor.Service.Controllers
{
    [ApiController]
    [Route("monitordata")]
    public class MonitorDataController : ControllerBase
    {
        private readonly IMonitorDataLogic _monitorDataLogic;

        // Constuct a MonitorDataController object.
        /// <summary>
        /// Constuct a MonitorDataController object and set an instance of MonitorDataLogic interface.
        /// </summary>
        public MonitorDataController()
        {
            _monitorDataLogic = new MonitorDataLogic();
        }

        // Defines the endpoint for CO2 generation.
        /// <summary>
        /// Defines the endpoint for CO2 generation based on patient type.
        /// </summary>
        /// <returns>
        /// A action result.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        [HttpGet, Route("generate-co2/{patientType}")]
        public ActionResult<CO2DatareadDTO> GenerateCO2(int patientType)
        {
            ActionResult<CO2DatareadDTO> cO2ToReturn;
            CO2 foundCO2 = _monitorDataLogic.GenerateCO2(patientType);
            CO2DatareadDTO foundDTO = CO2DatareadDTOConvert.FromCO2(foundCO2);
            
            if (foundDTO != null)
            {
                cO2ToReturn = Ok(foundDTO);
            }
            else
            {
                throw new Exception();
            }
            return cO2ToReturn;
        }

        // Defines the endpoint for HeartRate generation.
        /// <summary>
        /// Defines the endpoint for HeartRate generation based on patient type.
        /// </summary>
        /// <returns>
        /// A action result.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        [HttpGet, Route("generate-heart-rate/{patientType}")]
        public ActionResult<HeartRateDatareadDTO> GenerateHeartRate(int patientType)
        {
            ActionResult<HeartRateDatareadDTO> heartRateToReturn;
            HeartRate foundHeartRate = _monitorDataLogic.GenerateHeartRate(patientType);
            HeartRateDatareadDTO foundDTO = HeartRateDatareadDTOConvert.FromHeartRate(foundHeartRate);
            
            if (foundDTO != null)
            {
                heartRateToReturn = Ok(foundDTO);
            }
            else
            {
                throw new Exception();
            }
            return heartRateToReturn;
        }

        // Defines the endpoint for IBP generation.
        /// <summary>
        /// Defines the endpoint for IBP generation based on patient type.
        /// </summary>
        /// <returns>
        /// A action result.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        [HttpGet, Route("generate-ibp/{patientType}")]
        public ActionResult<IBPDatareadDTO> GenerateIBP(int patientType)
        {
            ActionResult<IBPDatareadDTO> iBPToReturn;
            IBP foundIBP = _monitorDataLogic.GenerateIBP(patientType);
            IBPDatareadDTO foundDTO = IBPDatareadDTOConvert.FromIBP(foundIBP);
            
            if (foundDTO != null)
            {
                iBPToReturn = Ok(foundDTO);
            }
            else
            {
                throw new Exception();
            }
            return iBPToReturn;
        }

        // Defines the endpoint for NIBP generation.
        /// <summary>
        /// Defines the endpoint for NIBP generation based on patient type.
        /// </summary>
        /// <returns>
        /// A action result.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        [HttpGet, Route("generate-nibp/{patientType}")]
        public ActionResult<NIBPDatareadDTO> GenerateNIBP(int patientType)
        {
            ActionResult<NIBPDatareadDTO> nIBPToReturn;
            NIBP foundNIBP = _monitorDataLogic.GenerateNIBP(patientType);
            NIBPDatareadDTO foundDTO = NIBPDatareadDTOConvert.FromNIBP(foundNIBP);
            
            if (foundDTO != null)
            {
                nIBPToReturn = Ok(foundDTO);
            }
            else
            {
                throw new Exception();
            }
            return nIBPToReturn;
        }

        // Defines the endpoint for pulse generation.
        /// <summary>
        /// Defines the endpoint for pulse generation based on patient type.
        /// </summary>
        /// <returns>
        /// A action result.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        [HttpGet, Route("generate-pulse/{patientType}")]
        public ActionResult<PulseDatareadDTO> GeneratePulse(int patientType)
        {
            ActionResult<PulseDatareadDTO> pulseToReturn;
            Pulse foundPulse = _monitorDataLogic.GeneratePulse(patientType);
            PulseDatareadDTO foundDTO = PulseDatareadDTOConvert.FromPulse(foundPulse);
            
            if (foundDTO != null)
            {
                pulseToReturn = Ok(foundDTO);
            }
            else
            {
                throw new Exception();
            }
            return pulseToReturn;
        }

        // Defines the endpoint for respiratory rate generation.
        /// <summary>
        /// Defines the endpoint for respiratory rate generation based on patient type.
        /// </summary>
        /// <returns>
        /// A action result.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        [HttpGet, Route("generate-respiratory-rate/{patientType}")]
        public ActionResult<RespiratoryRateDatareadDTO> GenerateRespiratoryRate(int patientType)
        {
            ActionResult<RespiratoryRateDatareadDTO> respiratoryRateToReturn;
            RespiratoryRate foundRespiratoryRate = _monitorDataLogic.GenerateRespiratoryRate(patientType);
            RespiratoryRateDatareadDTO foundDTO = RespiratoryRateDatareadDTOConvert.FromRespiratoryRate(foundRespiratoryRate);
            
            if (foundDTO != null)
            {
                respiratoryRateToReturn = Ok(foundDTO);
            }
            else
            {
                throw new Exception();
            }
            return respiratoryRateToReturn;
        }

        // Defines the endpoint for SpO2 generation.
        /// <summary>
        /// Defines the endpoint for SpO2 generation based on patient type.
        /// </summary>
        /// <returns>
        /// A action result.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        [HttpGet, Route("generate-spo2/{patientType}")]
        public ActionResult<SpO2DatareadDTO> GenerateSpO2(int patientType)
        {
            ActionResult<SpO2DatareadDTO> spO2ToReturn;
            SpO2 foundSpO2 = _monitorDataLogic.GenerateSpO2(patientType);
            SpO2DatareadDTO foundDTO = SpO2DatareadDTOConvert.FromSpO2(foundSpO2);
            
            if (foundDTO != null)
            {
                spO2ToReturn = Ok(foundDTO);
            }
            else
            {
                throw new Exception();
            }
            return spO2ToReturn;
        }

        // Defines the endpoint for temperature generation.
        /// <summary>
        /// Defines the endpoint for temperature generation based on patient type.
        /// </summary>
        /// <returns>
        /// A action result.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        [HttpGet, Route("generate-temperature/{patientType}")]
        public ActionResult<TemperatureDatareadDTO> GenerateTemperature(int patientType)
        {
            ActionResult<TemperatureDatareadDTO> temperatureToReturn;
            Temperature foundTemperature = _monitorDataLogic.GenerateTemperature(patientType);
            TemperatureDatareadDTO foundDTO = TemperatureDatareadDTOConvert.FromTemperature(foundTemperature);
            
            if (foundDTO != null)
            {
                temperatureToReturn = Ok(foundDTO);
            }
            else
            {
                throw new Exception();
            }
            return temperatureToReturn;
        }

        // Defines the endpoint for monitor event generation.
        /// <summary>
        /// Defines the endpoint for monitor event generation based on patient type.
        /// </summary>
        /// <returns>
        /// A action result.
        /// </returns>  
        /// <param name="patientType">Type of patient.</param>
        [HttpGet, Route("generate-monitor-event")]
        public ActionResult<MonitorEventDatareadDTO> GenerateMonitorEvent(int patientType)
        {
            ActionResult<MonitorEventDatareadDTO> monitorEventToReturn;
            MonitorEvent foundMonitorEvent = _monitorDataLogic.GenerateMonitorEvent(patientType);
            MonitorEventDatareadDTO foundDTO = MonitorEventDatareadDTOConvert.FromMonitorEvent(foundMonitorEvent);

            if (foundDTO != null)
            {
                monitorEventToReturn = Ok(foundDTO);
            }
            else
            {
                throw new Exception();
            }
            return monitorEventToReturn;
        }

        // Defines the endpoint for monitor data.
        /// <summary>
        /// Defines the endpoint for monitor data.
        /// </summary>
        /// <returns>
        /// A action result.
        /// </returns>  
        [HttpGet, Route("get-monitor-data")]
        public ActionResult<List<MonitorDataDatareadDTO>> GetAll()
        {
            ActionResult<List<MonitorDataDatareadDTO>> foundReturn;
            List<MonitorData> foundMonitorData = _monitorDataLogic.GetMonitorData();

            KnownTypesBinder knownTypesBinder = new KnownTypesBinder
            {
                KnownTypes = new List<Type>
                {
                }
            };

            string json = JsonConvert.SerializeObject(foundMonitorData, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects,
                SerializationBinder = knownTypesBinder
            });

            if (json != null)
            {
                foundReturn = Ok(json);
            }
            else
            {
                throw new Exception();
            }
            return foundReturn;
        }
    }
}