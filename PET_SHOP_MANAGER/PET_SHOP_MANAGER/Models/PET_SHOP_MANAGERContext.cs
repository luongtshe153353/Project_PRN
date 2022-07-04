using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace PET_SHOP_MANAGER.Models
{
    public partial class PET_SHOP_MANAGERContext : DbContext
    {
        public PET_SHOP_MANAGERContext()
        {
        }

        public PET_SHOP_MANAGERContext(DbContextOptions<PET_SHOP_MANAGERContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<InforAccount> InforAccounts { get; set; }
        public virtual DbSet<InforCustomer> InforCustomers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<TypeProduct> TypeProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("DeDoc"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InforAccount>(entity =>
            {
                entity.ToTable("InforAccount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.DateofBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fullname).HasMaxLength(50);

                entity.Property(e => e.Idacc).HasColumnName("IDAcc");

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdaccNavigation)
                    .WithMany(p => p.InforAccounts)
                    .HasForeignKey(d => d.Idacc)
                    .HasConstraintName("FK_InforAccount_Account");
            });

            modelBuilder.Entity<InforCustomer>(entity =>
            {
                entity.ToTable("InforCustomer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.InforCustomerNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.InforCustomer)
                    .HasConstraintName("FK_Order_InforCustomer");

                entity.HasOne(d => d.InforEmployeeNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.InforEmployee)
                    .HasConstraintName("FK_Order_InforAccount");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idorder).HasColumnName("IDOrder");

                entity.HasOne(d => d.IdorderNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.Idorder)
                    .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.Product)
                    .HasConstraintName("FK_OrderDetail_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnType("date")
                    .HasColumnName("dateofbirth");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK_Product_TypeProduct");
            });

            modelBuilder.Entity<TypeProduct>(entity =>
            {
                entity.ToTable("TypeProduct");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
