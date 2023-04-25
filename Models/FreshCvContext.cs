using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace freshCV.Models;

public partial class FreshCvContext : DbContext
{
    public FreshCvContext()
    {
    }

    public FreshCvContext(DbContextOptions<FreshCvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<Experience> Experiences { get; set; }

    public virtual DbSet<ReferencesTable> ReferencesTables { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=lab000000\\SQLEXPRESS;Database=freshCV;Trusted_Connection=True; TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Education>(entity =>
        {
            entity.HasKey(e => e.EduId).HasName("PK__educatio__84C108B29406824D");

            entity.ToTable("education");

            entity.Property(e => e.EduId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("eduID");
            entity.Property(e => e.Institution)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("institution");
            entity.Property(e => e.Major)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("major");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("userID");

            entity.HasOne(d => d.User).WithMany(p => p.Educations)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__education__userI__4BAC3F29");
        });

        modelBuilder.Entity<Experience>(entity =>
        {
            entity.HasKey(e => e.ExpId).HasName("PK__experien__F2AC96B065177E2B");

            entity.ToTable("experience");

            entity.Property(e => e.ExpId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("expID");
            entity.Property(e => e.Employer)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("employer");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("job_title");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("userID");

            entity.HasOne(d => d.User).WithMany(p => p.Experiences)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__experienc__userI__4E88ABD4");
        });

        modelBuilder.Entity<ReferencesTable>(entity =>
        {
            entity.HasKey(e => e.RefId).HasName("PK__referenc__BDA5A8693EAC9D5F");

            entity.ToTable("referencesTable");

            entity.Property(e => e.RefId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ref_id");
            entity.Property(e => e.Company)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("company");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmpRole)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("emp_role");
            entity.Property(e => e.EmployerName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("employer_name");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("userID");

            entity.HasOne(d => d.User).WithMany(p => p.ReferencesTables)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__reference__userI__5441852A");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.SkillId).HasName("PK__skills__AE6A6BDF15DB5778");

            entity.ToTable("skills");

            entity.Property(e => e.SkillId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("skillID");
            entity.Property(e => e.SkillDesc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("skill_desc");
            entity.Property(e => e.SkillType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("skill_type");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("userID");

            entity.HasOne(d => d.User).WithMany(p => p.Skills)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__skills__userID__5165187F");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__users__CB9A1CDFE6798C03");

            entity.ToTable("users");

            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("userID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.Phone).HasColumnName("phone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
