namespace SolarEdge.Models;

public class PrimaryModule
{
    public string ManufacturerName { get; set; } = string.Empty;
    public string ModelName { get; set; } = string.Empty;
    public double MaximumPower { get; set; }
    public double TemperatureCoef { get; set; }
    public string Zip { get; set; } = string.Empty;
    public string TimeZone { get; set; } = string.Empty;
    public string CountryCode { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
