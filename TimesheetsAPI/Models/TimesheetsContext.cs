using Microsoft.EntityFrameworkCore;

namespace TimesheetsAPI.Models
{
    public class TimesheetsContext :DbContext
    {
        public string DbPath { get; }

        public TimesheetsContext(string dbc) : this()
        {

        }


        public TimesheetsContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);

            DbPath = Path.Join(path, "timesheets.db");
        }

        //sets the class as a database table
        public DbSet<Location> Locations => Set<Location>();

        public DbSet<Timesheet> Timesheets => Set<Timesheet>();

        public DbSet<Staff> Staffs => Set<Staff>();

        public DbSet<Client> Clients => Set<Client>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite($"Data Source = {DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Staff>().HasData(new Staff(7, "wintersgill", "thomas", "123@me.com"),
                                                 new Staff(8, "smith", "jimmy", "email@gmail.com")
                );

            modelBuilder.Entity<Location>().HasData(new Location(1, "Tesco", "Redcar")
                );

            modelBuilder.Entity<Client>().HasData(new Client(1, "Tesco", "RedcarHighStreet", "John", "07532564789", "John@gmail.com"));


        }
    }
}

