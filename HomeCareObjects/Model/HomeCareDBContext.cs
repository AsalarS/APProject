using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HomeCareObjects.Model
{
    public partial class HomeCareDBContext : DbContext
    {
        public HomeCareDBContext()
        {
        }

        public HomeCareDBContext(DbContextOptions<HomeCareDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<ServiceRequest> ServiceRequests { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=HomeCare;Trusted_Connection=True;").EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.ManagerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Categories_Users");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_Comments_ServiceRequests");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_Documents_ServiceRequests");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Logs_Users");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notifications_Users");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Services_Categories");

                entity.HasOne(d => d.Technician)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.TechnicianId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Services_Users");
            });

            modelBuilder.Entity<ServiceRequest>(entity =>
            {
                entity.Property(e => e.RequestStatus).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ServiceRequestCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceRequests_Users");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceRequests)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_ServiceRequests_Services");

                entity.HasOne(d => d.Technician)
                    .WithMany(p => p.ServiceRequestTechnicians)
                    .HasForeignKey(d => d.TechnicianId)
                    .HasConstraintName("FK_ServiceRequests_Users1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasMany(d => d.ServicesNavigation)
                    .WithMany(p => p.Technicians)
                    .UsingEntity<Dictionary<string, object>>(
                        "TechniciansService",
                        l => l.HasOne<Service>().WithMany().HasForeignKey("ServiceId").HasConstraintName("FK_Technicians_Services_Services"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("TechnicianId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Technicians_Services_Users"),
                        j =>
                        {
                            j.HasKey("TechnicianId", "ServiceId");

                            j.ToTable("Technicians_Services");

                            j.IndexerProperty<int>("TechnicianId").HasColumnName("TechnicianID");

                            j.IndexerProperty<int>("ServiceId").HasColumnName("ServiceID");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
