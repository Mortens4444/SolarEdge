namespace SolarEdge.Models;

public class Site
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Status { get; set; } = String.Empty;
    public double PeakPower { get; set; }
    public string Currency { get; set; } = String.Empty;
    public string InstallationDate { get; set; } = String.Empty;
    public string Notes { get; set; } = String.Empty;
    public string Type { get; set; } = String.Empty;
    public int AlertQuantity { get; set; }
    public int HighestImpact { get; set; }
    public Location Location { get; set; } = new();
    public PrimaryModule PrimaryModule { get; set; } = new();
    public Uris Uris { get; set; } = new();
}