using Miningcore.Blockchain;
using Miningcore.Configuration;

namespace Miningcore.Mining;

public interface IMiningPool
{
    PoolConfig Config { get; }
    PoolStats PoolStats { get; }
    BlockchainStats NetworkStats { get; }
    double ShareMultiplier { get; }
    void Configure(PoolConfig pc, ClusterConfig cc);
    double HashrateFromShares(double shares, double interval);

    /// <summary>
    /// Best share difficulty per worker across the miner's currently connected sessions
    /// </summary>
    Dictionary<string, double> GetSessionBestShares(string miner);
    Task RunAsync(CancellationToken ct);
}
