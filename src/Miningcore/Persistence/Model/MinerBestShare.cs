namespace Miningcore.Persistence.Model;

public class MinerBestShare
{
    public string PoolId { get; set; }
    public string Miner { get; set; }
    public string Worker { get; set; }
    public double Difficulty { get; set; }
    public DateTime Created { get; set; }
}
