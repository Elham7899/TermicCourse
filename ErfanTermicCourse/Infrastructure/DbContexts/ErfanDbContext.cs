using Microsoft.EntityFrameworkCore;

namespace ErfanTermicCourse.Infrastructure.DbContexts;

public class ErfanDbContext : DbContext
{
    public ErfanDbContext(DbContextOptions options) :base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.ApplyConfigurationsFromAssembly(typeof(ErfanDbContext).Assembly);
	}
}