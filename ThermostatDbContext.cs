using Microsoft.EntityFrameworkCore;

internal class ThermostatDbContext : DbContext
{
    public DbSet<ThermostatState> States {get;set;}
    public string DbPath{get;}
    public ThermostatDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "gas.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
