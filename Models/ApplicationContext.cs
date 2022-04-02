using Metrology.Services;
using System;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Metrology.Models
{
    internal class ApplicationContext : DbContext
    {    

        public ApplicationContext():base()
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<PresenceStatus> PresenceStatus { get; set; }
        public DbSet<LocationType> LocationTypes { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Contractor> Contractor{ get; set; }
        public DbSet<TransferLog> TransferLog { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<VerificationJournal> VerificationJournals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseNpgsql("Server=192.168.226.131;Port=5432;Database=metrology;Username=madmin;Password=madmin; pooling=true; SearchPath=metrology");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("metrology");

            //USER
            modelBuilder.Entity<User>().Property(x => x.BirthDay).HasColumnType("TIMESTAMP(0)").IsRequired();
            modelBuilder.Entity<User>().Property(x => x.RegistrationDate).HasColumnType("TIMESTAMP(0)").IsRequired();
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    Name = "Admin",
                    Email = "admin@admin.ru",
                    Surname = "Adminovich",
                    PatrName = "Adminov",
                    BirthDay = DateTime.Now,
                    RegistrationDate = DateTime.Now,
                    Password = LoginService.GetHashedPassword("admin"),
                    Login = "admin",
                    Phone ="88888888888"
                   
                });

            // Role
            modelBuilder.Entity<Role>().HasData(
                    new Role
                    {
                        Id = 1,
                        Name = "Администратор",
                        Privelegies = 7
                    },

                    new Role
                    {
                        Id = 2,
                        Name = "Главный Метролог",
                        Privelegies = 5
                    },
                    new Role
                    {
                        Id = 3,
                        Name = "Метролог",
                        Privelegies = 3
                    });
            //PresenceStatus
            modelBuilder.Entity<PresenceStatus>().HasData(
                new PresenceStatus() { Id = 1, Name = "В Наличие" },
                new PresenceStatus() { Id = 2, Name = "Передан" });
            //LocationType
            modelBuilder.Entity<LocationType>().HasData(
                new LocationType() { Id = 1, Name = "В Ремонте" },
                new LocationType() { Id = 2, Name = "ТСМ" },
                new LocationType() { Id = 3, Name = "Куст" });

            //DeviceType

            modelBuilder.Entity<DeviceType>().HasData(
                new DeviceType
                {
                    ID = 1,
                    Name = "Измерительные"
                });

            //Device

            modelBuilder.Entity<Device>().Property(x =>x.DeviceDate).HasColumnType("TIMESTAMP(0)").IsRequired();
            modelBuilder.Entity<Device>().Property(x =>x.DateExplotationStart).HasColumnType("TIMESTAMP(0)").IsRequired();
            modelBuilder.Entity<Device>().Property(x =>x.DateExplotationEnd).HasColumnType("TIMESTAMP(0)").IsRequired();

            //TransferLog
            modelBuilder.Entity<TransferLog>().Property(x => x.TransferDate).HasColumnType("TIMESTAMP(0)");
            modelBuilder.Entity<TransferLog>().Property(x => x.AcceptedDate).HasColumnType("TIMESTAMP(0)");

            //VerificationJournal
            modelBuilder.Entity<VerificationJournal>().Property(x => x.VerificationDate).HasColumnType("TIMESTAMP(0)");


        }
    }
}