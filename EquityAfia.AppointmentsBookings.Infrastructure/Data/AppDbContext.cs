
/*
using Microsoft.EntityFrameworkCore;
using EquityAfia.AppointmentsBookings.Domain.Entities;

namespace EquityAfia.AppointmentsBookings.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<AppointmentBooking> AppointmentBookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppointmentBooking>(entity =>
            {
                entity.ToTable("AppointmentBookings");
                entity.HasKey(e => e.AppointmentId);

                entity.Property(e => e.AppointmentId).IsRequired();
                entity.Property(e => e.BookFor).IsRequired();
                entity.Property(e => e.Service).IsRequired();
                entity.Property(e => e.Date).IsRequired();
                entity.Property(e => e.AppointmentType).IsRequired();
                entity.Property(e => e.FullName).IsRequired(false);
                entity.Property(e => e.PhoneNumber).IsRequired();
                entity.Property(e => e.IdNumber).IsRequired();
                entity.Property(e => e.Gender).IsRequired();
                entity.Property(e => e.Age).IsRequired();
                entity.Property(e => e.Status).HasDefaultValue("pending");
            });
        }
    }
}


*/

































using Microsoft.EntityFrameworkCore;
using EquityAfia.AppointmentsBookings.Domain.Entities;

namespace EquityAfia.AppointmentsBookings.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<AppointmentBooking> AppointmentBookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppointmentBooking>(entity =>
            {
                entity.ToTable("AppointmentBookings");
                entity.HasKey("AppointmentId");

                entity.Property(e => e.AppointmentId).IsRequired();
                entity.Property(e => e.BookFor).IsRequired();
                entity.Property(e => e.Service).IsRequired();
                entity.Property(e => e.Date).IsRequired();
                entity.Property(e => e.AppointmentType).IsRequired();
                entity.Property(e => e.FullName).IsRequired();
                entity.Property(e => e.PhoneNumber).IsRequired();
                entity.Property(e => e.IdNumber).IsRequired();
                entity.Property(e => e.Gender).IsRequired();
                entity.Property(e => e.Age).IsRequired();
                entity.Property(e => e.Status).IsRequired();

            });
        }
    }
}
