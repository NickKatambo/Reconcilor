﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Reconcilor.Domain.Models;
using Reconcilor.Domain.ViewModels;

namespace Reconcilor.Infrastrcuture.DataContext;

public partial class ReconcilorContext : DbContext
{
    public ReconcilorContext(DbContextOptions<ReconcilorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BeltsRaw> BeltsRaws { get; set; }

    public virtual DbSet<Bin> Bins { get; set; }

    public virtual DbSet<Level> Levels { get; set; }

    public virtual DbSet<Measure> Measures { get; set; }

    public virtual DbSet<MineModel> MineModels { get; set; }

    public virtual DbSet<Mining> Minings { get; set; }

    public virtual DbSet<RMD> RMDs { get; set; }

    public virtual DbSet<Shaft> Shafts { get; set; }

    public virtual DbSet<Shift> Shifts { get; set; }

    public virtual DbSet<StockPile> StockPiles { get; set; }

    public virtual DbSet<StopeDevelopment> StopeDevelopments { get; set; }

    public virtual DbSet<Surveyor> Surveyors { get; set; }

    public virtual DbSet<UGStopeDetail> UGStopeDetails { get; set; }

    public virtual DbSet<UGStopesRaw> UGStopesRaws { get; set; }

    public virtual DbSet<UGSurvey> UGSurveys { get; set; }
    public virtual DbSet<StockPileViewModel> StockPileViewModel { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BeltsRaw>(entity =>
        {
            entity.HasOne(d => d.Shaft).WithMany(p => p.BeltsRaws)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BeltsRaw_Shaft");

            entity.HasOne(d => d.Shift).WithMany(p => p.BeltsRaws)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BeltsRaw_Shift1");
        });

        modelBuilder.Entity<Measure>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<StockPile>(entity =>
        {
            entity.HasOne(d => d.StockP).WithMany(p => p.StockPiles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StockPiles_Bin");
        });

        modelBuilder.Entity<StopeDevelopment>(entity =>
        {
            entity.HasOne(d => d.Level).WithMany(p => p.StopeDevelopments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StopeDevelopment_Level");

            entity.HasOne(d => d.MineModel).WithMany(p => p.StopeDevelopments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StopeDevelopment_MineModel");

            entity.HasOne(d => d.Mining).WithMany(p => p.StopeDevelopments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StopeDevelopment_Mining");

            entity.HasOne(d => d.Shaft).WithMany(p => p.StopeDevelopments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StopeDevelopment_Shaft");
        });

        modelBuilder.Entity<UGStopeDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StopeDetail");

            entity.HasOne(d => d.Model).WithMany(p => p.UGStopeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UGStopeDetail_MineModel");

            entity.HasOne(d => d.Shaft).WithMany(p => p.UGStopeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UGStopeDetail_Shaft");

            entity.HasOne(d => d.Stope).WithMany(p => p.UGStopeDetails)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UGStopeDetail_StopeDevelopment");
        });

        modelBuilder.Entity<UGStopesRaw>(entity =>
        {
            entity.HasOne(d => d.Level).WithMany(p => p.UGStopesRaws)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UGStopesRaw_Level");

            entity.HasOne(d => d.Shaft).WithMany(p => p.UGStopesRaws)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UGStopesRaw_Shaft");

            entity.HasOne(d => d.Shift).WithMany(p => p.UGStopesRaws)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UGStopesRaw_Shift");

            entity.HasOne(d => d.Stope).WithMany(p => p.UGStopesRaws)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UGStopesRaw_StopeDevelopment");
        });

        modelBuilder.Entity<UGSurvey>(entity =>
        {
            entity.HasOne(d => d.Level).WithMany(p => p.UGSurveys)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UGSurvey_Level");

            entity.HasOne(d => d.Model).WithMany(p => p.UGSurveys)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UGSurvey_MineModel");

            entity.HasOne(d => d.Shaft).WithMany(p => p.UGSurveys)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UGSurvey_Shaft");

            entity.HasOne(d => d.Stope).WithMany(p => p.UGSurveys)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UGSurvey_StopeDevelopment");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}