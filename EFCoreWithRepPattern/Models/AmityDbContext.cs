using System;
using System.Collections.Generic;
using EFCoreWithRepPattern.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWithRepPattern.Models;

public partial class AmityDbContext : DbContext
{
    public AmityDbContext()
    {
    }

    public AmityDbContext(DbContextOptions<AmityDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Batch> Batches { get; set; }

    public virtual DbSet<CourseDatum> CourseData { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<St> Sts { get; set; }
    // Sql 

    public virtual DbSet<TbUser> TbUsers { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Customer> Customers  { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ANAMIKA\\SQLSERVER;Database=AmityDB;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Batch>(entity =>
        {
            entity.ToTable("BAtches");

            entity.Property(e => e.Course).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<CourseDatum>(entity =>
        {
            entity.Property(e => e.Name)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.Address).HasDefaultValueSql("(N'')");
        });

        modelBuilder.Entity<St>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("st");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.Email);

            entity.ToTable("tbUser");

            entity.Property(e => e.Email).ValueGeneratedNever();
            entity.Property(e => e.FirstName).HasMaxLength(20);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });
        modelBuilder.Entity<Role>().
    HasData(new Role
    {
        RoleID=1,
        RoleName="Admin"
    }, new Role
    { 
        RoleID=2,
    RoleName="Manager"
    }, new Role
     {
            RoleID = 3,
    RoleName = "Employee"
    }
    );


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
