using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TowhidIMS.Models.Codefirst
{
    public partial class dbcontext : DbContext
    {
        public dbcontext()
            : base("name=dbcontext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<MyBusinessInfo> MyBusinessInfoes { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<POD> PODs { get; set; }
        public virtual DbSet<PO> POes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SOD> SODs { get; set; }
        public virtual DbSet<SO> SOes { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Remarks)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.bizId)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Remarks)
                .IsFixedLength();

            modelBuilder.Entity<Department>()
                .Property(e => e.bizId)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeTypeId)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.RightId)
                .HasPrecision(4, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Designation)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Casual)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Earned)
                .HasPrecision(3, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.IsActive)
                .HasPrecision(2, 0);

            modelBuilder.Entity<Employee>()
                .Property(e => e.bizId)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.Remarks)
                .IsFixedLength();

            modelBuilder.Entity<Location>()
                .Property(e => e.bizId)
                .IsUnicode(false);

            modelBuilder.Entity<MyBusinessInfo>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Payment>()
                .Property(e => e.SOId)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.PaymentMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<POD>()
                .Property(e => e.Auto)
                .HasPrecision(18, 0);

            modelBuilder.Entity<POD>()
                .Property(e => e.POId)
                .IsUnicode(false);

            modelBuilder.Entity<POD>()
                .Property(e => e.PerPack)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PO>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<PO>()
                .Property(e => e.PODId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.RackPosition)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.BarCode)
                .IsUnicode(false);

            modelBuilder.Entity<SOD>()
                .Property(e => e.Auto)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SOD>()
                .Property(e => e.SOId)
                .IsUnicode(false);

            modelBuilder.Entity<SOD>()
                .Property(e => e.PerPack)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SO>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<SO>()
                .Property(e => e.SODId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Balance)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.bizId)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);
        }
    }
}
