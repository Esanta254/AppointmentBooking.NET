

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
                entity.Property(e => e.AppointmentType).IsRequired();
                entity.Property(e => e.Name).IsRequired(false);
                entity.Property(e => e.PhoneNumber).IsRequired();
                entity.Property(e => e.IdNumber).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Gender).IsRequired();
                entity.Property(e => e.Age).IsRequired();
                entity.Property(e => e.AppointmentStatus).HasDefaultValue("pending");
                entity.Property(e => e.PaymentSatus).HasDefaultValue("Not Paid");
                entity.Property(e => e.Residence).IsRequired();
                entity.Property(e => e.AppointmentDate).IsRequired();
                entity.Property(e => e.AppointmentTime).IsRequired();
            });
        }
    }
}

