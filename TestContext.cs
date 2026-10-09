using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TrelloToTrackingTime;

public partial class TestContext : DbContext
{
    public TestContext()
    {
    }

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ReportDatum> ReportData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("REPORT_DB_CONNECTION_STRING"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ReportDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'Report Data$'");

            entity.Property(e => e.Board).HasMaxLength(255);
            entity.Property(e => e.Card).HasMaxLength(255);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.EndTime).HasMaxLength(255);
            entity.Property(e => e.List).HasMaxLength(255);
            entity.Property(e => e.Member).HasMaxLength(255);
            entity.Property(e => e.StartTime).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
