using BCU_EFCORE.Entities;
using BCU_EFCORE.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace BCU_EFCORE.Infrastructure;

public class BCUContext : DbContext
{
    public DbSet<BCU_Account> BcuAccounts { get; set; }
    public DbSet<Building> Building { get; set; }
    public DbSet<Dependent> Dependents { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Hobby> Hobbies { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Participation> Participations { get; set; }
    public DbSet<Plant> Plants { get; set; }
    public DbSet<Project> Projects { get; set; }

    public BCUContext(DbContextOptions options) : base(options) {}

    public void OnConfiguring()
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new BCU_AccountConfiguration());
        builder.ApplyConfiguration(new BuildingConfiguration());
        builder.ApplyConfiguration(new DependentConfiguration());
        builder.ApplyConfiguration(new EmployeeConfiguration());
        builder.ApplyConfiguration(new HobbyConfiguration());
        builder.ApplyConfiguration(new JobConfiguration());
        builder.ApplyConfiguration(new ManagerConfiguration());
        builder.ApplyConfiguration(new ParticipationConfiguration());
        builder.ApplyConfiguration(new PlantConfiguration());
        builder.ApplyConfiguration(new ProjectConfiguration());
    }
}