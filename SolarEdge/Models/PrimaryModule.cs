namespace SolarEdge.Models;

public class PrimaryModule
{
    public string ManufacturerName { get; set; } = String.Empty;
    public string ModelName { get; set; } = String.Empty;
    public double MaximumPower { get; set; }
    public double TemperatureCoef { get; set; }
    public string Zip { get; set; } = String.Empty;
    public string TimeZone { get; set; } = String.Empty;
    public string CountryCode { get; set; } = String.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
