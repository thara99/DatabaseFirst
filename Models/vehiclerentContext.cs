using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DatabaseFirst.Models
{
    public partial class vehiclerentContext : DbContext
    {
        public vehiclerentContext()
        {
        }

        public vehiclerentContext(DbContextOptions<vehiclerentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Driverdetail> Driverdetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-H8B00RC\\SQLEXPRESS;Initial Catalog=vehiclerent;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Booking");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer Name");

                entity.Property(e => e.DriverId).HasColumnName("Driver ID");

                entity.Property(e => e.ReservationDate).HasColumnName("Reservation Date");

                entity.Property(e => e.ReservationNo).HasColumnName("Reservation No");

                entity.Property(e => e.VehicleNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Vehicle Number");
            });

            modelBuilder.Entity<Driverdetail>(entity =>
            {
                entity.HasKey(e => e.Regno);

                entity.ToTable("driverdetails");

                entity.Property(e => e.Regno)
                    .ValueGeneratedNever()
                    .HasColumnName("regno");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Contactno)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("contactno");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Exp).HasColumnName("exp");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nic)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nic");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
