using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DemoStoreDbContext.Models
{
	public partial class Demo_08162021batchContext : DbContext
	{
		public Demo_08162021batchContext()
		{
		}

		public Demo_08162021batchContext(DbContextOptions<Demo_08162021batchContext> options)
			: base(options)
		{
		}

		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<ItemizedOrder> ItemizedOrders { get; set; }
		public virtual DbSet<Product> Products { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server=.\\SQLExpress04;Database=Demo_08162021batch;Trusted_Connection=True;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

			modelBuilder.Entity<Customer>(entity =>
			{
				entity.Property(e => e.FirstName)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.LastName)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<ItemizedOrder>(entity =>
			{
				entity.HasKey(e => e.ItemizedId)
					.HasName("PK__Itemized__AB3A49C5EE7B0183");

				entity.Property(e => e.ItemizedId).HasDefaultValueSql("(newid())");

				entity.Property(e => e.OrderDate).HasColumnType("date");

				entity.HasOne(d => d.Customer)
					.WithMany(p => p.ItemizedOrders)
					.HasForeignKey(d => d.CustomerId)
					.HasConstraintName("FK__ItemizedO__Custo__403A8C7D");

				entity.HasOne(d => d.Product)
					.WithMany(p => p.ItemizedOrders)
					.HasForeignKey(d => d.ProductId)
					.HasConstraintName("FK__ItemizedO__Produ__412EB0B6");
			});

			modelBuilder.Entity<Product>(entity =>
			{
				entity.Property(e => e.ProductDescription)
					.IsRequired()
					.HasMaxLength(100)
					.IsUnicode(false);

				entity.Property(e => e.ProductName)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.ProductPrice).HasColumnType("decimal(19, 4)");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
