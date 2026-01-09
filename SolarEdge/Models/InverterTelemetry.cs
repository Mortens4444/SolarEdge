namespace SolarEdge.Models;

public class InverterTelemetry
{
    public string Date { get; set; }
    public double TotalActivePower { get; set; } // W
    public double L1Data_AcVoltage { get; set; } // V
    public double L1Data_AcCurrent { get; set; } // A
    public double DcVoltage { get; set; }        // V
    public double Temperature { get; set; }      // °C
}
