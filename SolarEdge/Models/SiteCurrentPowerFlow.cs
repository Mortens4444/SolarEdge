namespace SolarEdge.Models;

public class SiteCurrentPowerFlow
{
    public string Unit { get; set; }
    
    public List<PowerFlowConnection> Connections { get; set; } = new();

    public PowerFlowValue Grid { get; set; }

    /// <summary>
    /// House consumption
    /// </summary>
    public PowerFlowValue Load { get; set; }

    /// <summary>
    /// Solar panel production
    /// </summary>
    public PowerFlowValue PV { get; set; }
}