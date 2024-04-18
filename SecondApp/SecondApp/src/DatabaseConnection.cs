namespace SecondApp;

using Microsoft.EntityFrameworkCore;

public class DatabaseConnection : DbContext
{
    
    public DbSet<Numbers> Numbers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=app.db");
    }
}