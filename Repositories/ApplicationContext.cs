using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using test2.Models;
public class ApplicationContext : DbContext {
    public DbSet<Film> Films => Set<Film>();
    public DbSet<Hall> Halls => Set<Hall>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<Seans> Seanses => Set<Seans>();
    public DbSet<Ticket> Tickets => Set<Ticket>();
    public DbSet<Transaction> Transactions => Set<Transaction>();
    

    public ApplicationContext() => Database.EnsureCreated();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
    }
}