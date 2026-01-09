namespace SolarEdge.Models;

public class Alert
{
    public string Name { get; set; } = string.Empty;
    public string Severity { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string StartTime { get; set; } = string.Empty;
    public string? LastUpdateTime { get; set; }
    public string? Description { get; set; }
}
