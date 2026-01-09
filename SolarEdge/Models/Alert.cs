namespace SolarEdge.Models;

public class Alert
{
    public string Name { get; set; } = String.Empty;
    public string Severity { get; set; } = String.Empty;
    public string Status { get; set; } = String.Empty;
    public string StartTime { get; set; } = String.Empty;
    public string? LastUpdateTime { get; set; }
    public string? Description { get; set; }
}
