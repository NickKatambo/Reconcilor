﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Reconcilor.Domain.Models;

[Table("StopeDefinition")]
public partial class StopeDefinition
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string StopeID { get; set; }

    public int ShaftId { get; set; }

    public int LevelId { get; set; }

    public int MiningId { get; set; }

    public int MineModelId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Crosscut { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateEntered { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Tonnes { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TCu { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TCo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Cu { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Co { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Comment { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string EnteredBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EnteredOn { get; set; }

    [ForeignKey("LevelId")]
    [InverseProperty("StopeDefinitions")]
    public virtual Level Level { get; set; }

    [ForeignKey("MineModelId")]
    [InverseProperty("StopeDefinitions")]
    public virtual MineModel MineModel { get; set; }

    [ForeignKey("MiningId")]
    [InverseProperty("StopeDefinitions")]
    public virtual Mining Mining { get; set; }

    [ForeignKey("ShaftId")]
    [InverseProperty("StopeDefinitions")]
    public virtual Shaft Shaft { get; set; }

    [InverseProperty("Stope")]
    public virtual ICollection<UGStopesRaw> UGStopesRaws { get; set; } = new List<UGStopesRaw>();

    [InverseProperty("Stope")]
    public virtual ICollection<UGSurvey> UGSurveys { get; set; } = new List<UGSurvey>();
}