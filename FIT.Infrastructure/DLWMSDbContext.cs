using FIT.Data;

using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext
    {
        //C:\Users\online\Desktop
        private readonly string dbPutanja;// = "Data Source = C:\\Users\\online\\Desktop\\DLWMS.db";

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Uloga)
                .WithMany(u => u.Student)
                .UsingEntity(t => t.ToTable("StudentiUloge"));
        }

        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Semestar> Semestri { get; set; }
        public DbSet<Uloga> Uloge { get; set; }

        public DbSet<PolozeniPredmet> PolozeniPredmeti { get; set; }




    }
}