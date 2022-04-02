using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class ThermostatState
{
    public string deviceIP { get; set; }
    public string deviceId { get; set; }
    
    [Key]
    [JsonConverter(typeof(DateTimeOffsetJsonConverter))]
    public DateTimeOffset latestReportTime { get; set; }
    public double burningHours { get; set; }
    public double roomTemperature { get; set; }
    public double outsideTemperature { get; set; }
    public double dhwSetpoint { get; set; }
    public double dhwWaterTemperature { get; set; }
    public double chSetpoint { get; set; }
    public double chWaterTemperature { get; set; }
    public double chWaterPressure { get; set; }
    public double chReturnTemperature { get; set; }
    public double targetTemperature { get; set; }
    public int deviceStatus { get; set; }
    public int connectionStatus { get; set; }
    public string deviceErrors { get; set; }
    public string boilerErrors { get; set; }
    public double dbgOutsideTemp { get; set; }
    public double pcbTemp { get; set; }
    public double dhwWaterTemp { get; set; }
    public double dhwWaterPres { get; set; }
    public int boilerStatus { get; set; }
    public int boilerConfig { get; set; }
    public double chTimeToTemp { get; set; }
    public double powerCons { get; set; }
    public int rssi { get; set; }
    public double current { get; set; }
    public double voltage { get; set; }
    public int resets { get; set; }
    public int memoryAllocation { get; set; }
    public int chStatus { get; set; }
    public int chControl_mode { get; set; }
    public int chMode { get; set; }
    public double chModeDuration { get; set; }   
     public double chModeTemp { get; set; }
    public int dhwStatus { get; set; }
    public int dhwMode { get; set; }
    public double weatherTemp { get; set; }
    public int weatherStatus { get; set; }
    public double vacationDuration { get; set; }
    public double extendDuration { get; set; }
    public double fireplaceDuration { get; set; }
    public string flameStatus { get; set; }
    public string atagOneVersion { get; set; }
    public string macAddress { get; set; }
}