using Microsoft.EntityFrameworkCore;
using Voxta.Domain.Entities;

namespace Voxta.Infrastructure.Data;

public class VoxtaDbContext : DbContext
{
    public VoxtaDbContext(DbContextOptions<VoxtaDbContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Agent> Agents { get; set; } = null!;
    public DbSet<Call> Calls { get; set; } = null!;
    public DbSet<Recording> Recordings { get; set; } = null!;
    public DbSet<Transcript> Transcripts { get; set; } = null!;
    public DbSet<AISummary> AISummaries { get; set; } = null!;
}