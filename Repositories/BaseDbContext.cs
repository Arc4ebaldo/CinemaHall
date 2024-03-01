using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using test2.Models;

namespace test2.Repositories;

public partial class BaseDbContext : DbContext
{
    public BaseDbContext()
    {
    }

    public BaseDbContext(DbContextOptions<BaseDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Film> Films { get; set; }

    public virtual DbSet<Hall> Halls { get; set; }

    public virtual DbSet<Sean> Seans { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<Tran> Trans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
// warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("database=Base_db;server=localhost;port=5432;uid=postgres;pwd=123456");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("employee_pkey");

            entity.ToTable("employee");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .HasColumnName("last_name");
            entity.Property(e => e.Position)
                .HasMaxLength(30)
                .HasColumnName("position");
        });

        modelBuilder.Entity<Film>(entity =>
        {
            entity.HasKey(e => e.FilmId).HasName("film_pkey");

            entity.ToTable("film");

            entity.Property(e => e.FilmId).HasColumnName("film_id");
            entity.Property(e => e.Descript)
                .HasMaxLength(101)
                .HasColumnName("descript");
            entity.Property(e => e.Director)
                .HasMaxLength(30)
                .HasColumnName("director");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Genre)
                .HasMaxLength(30)
                .HasColumnName("genre");
            entity.Property(e => e.ReleaseYear).HasColumnName("release_year");
            entity.Property(e => e.Title)
                .HasMaxLength(30)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Hall>(entity =>
        {
            entity.HasKey(e => e.HallId).HasName("hall_pkey");

            entity.ToTable("hall");

            entity.Property(e => e.HallId).HasColumnName("hall_id");
            entity.Property(e => e.Capacity)
                .HasMaxLength(30)
                .HasColumnName("capacity");
            entity.Property(e => e.Namy)
                .HasMaxLength(30)
                .HasColumnName("namy");
        });

        modelBuilder.Entity<Sean>(entity =>
        {
            entity.HasKey(e => e.SeansId).HasName("seans_pkey");

            entity.ToTable("seans");

            entity.Property(e => e.SeansId).HasColumnName("seans_id");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.FilmId).HasColumnName("film_id");
            entity.Property(e => e.HallId).HasColumnName("hall_id");
            entity.Property(e => e.StartDatetime).HasColumnName("start_datetime");

            entity.HasOne(d => d.Film).WithMany(p => p.Seans)
                .HasForeignKey(d => d.FilmId)
                .HasConstraintName("seans_film_id_fkey");

            entity.HasOne(d => d.Hall).WithMany(p => p.Seans)
                .HasForeignKey(d => d.HallId)
                .HasConstraintName("seans_hall_id_fkey");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("ticket_pkey");

            entity.ToTable("ticket");

            entity.Property(e => e.TicketId).HasColumnName("ticket_id");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.SeansId).HasColumnName("seans_id");
            entity.Property(e => e.Seat).HasColumnName("seat");
            entity.Property(e => e.Statue).HasColumnName("statue");

            entity.HasOne(d => d.Seans).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.SeansId)
                .HasConstraintName("ticket_seans_id_fkey");
        });

        modelBuilder.Entity<Tran>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("trans_pkey");

            entity.ToTable("trans");

            entity.Property(e => e.TransId).HasColumnName("trans_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Dattim)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dattim");
            entity.Property(e => e.Tip)
                .HasMaxLength(30)
                .HasColumnName("tip");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
