using System;
using System.Collections.Generic;
using Account.DataAccess.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Account.DataAccess.EF.Context;

public partial class AccountContext : DbContext
{
    public AccountContext()
    {
    }

    public AccountContext(DbContextOptions<AccountContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=Account;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddrId);

            entity.ToTable("Address");

            entity.Property(e => e.AddrId)
                .ValueGeneratedNever()
                .HasColumnName("Addr_ID");
            entity.Property(e => e.Apt).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.Street).HasMaxLength(255);
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.User).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Address_Users");
        });

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.ToTable("Admin");

            entity.Property(e => e.AdminId)
                .ValueGeneratedNever()
                .HasColumnName("Admin_ID");
            entity.Property(e => e.AdminEmail)
                .HasMaxLength(50)
                .HasColumnName("Admin_Email");
            entity.Property(e => e.AdminPasswordHash)
                .HasMaxLength(255)
                .HasColumnName("Admin_Password_Hash");
            entity.Property(e => e.AdminRole).HasColumnName("Admin_Role");
            entity.Property(e => e.AdminUserName)
                .HasMaxLength(50)
                .HasColumnName("Admin_UserName");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.ToTable("Payment");

            entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");
            entity.Property(e => e.CardNumHash)
                .HasMaxLength(255)
                .HasColumnName("CardNum_Hash");
            entity.Property(e => e.CardType)
                .HasMaxLength(50)
                .HasColumnName("Card_Type");
            entity.Property(e => e.CardholderName)
                .HasMaxLength(255)
                .HasColumnName("Cardholder_Name");
            entity.Property(e => e.ExpirationDate)
                .HasMaxLength(50)
                .HasColumnName("Expiration_Date");
            entity.Property(e => e.SecHash)
                .HasMaxLength(255)
                .HasColumnName("Sec_Hash");
            entity.Property(e => e.UserId).HasColumnName("User_ID");

            entity.HasOne(d => d.User).WithMany(p => p.Payments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Payment_Users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("User_ID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .HasColumnName("Password_Hash");
            entity.Property(e => e.Telephone).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
