﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Reconcilor.Domain.Models;

[Table("StopeDevelopment")]
public partial class StopeDevelopment
{
    [Key]
    public int StopeId { get; set; }

    public int ShaftId { get; set; }

    public int LevelId { get; set; }

    public int MiningId { get; set; }

    public int MineModelId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Crosscut { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Comment { get; set; }

    [ForeignKey("LevelId")]
    [InverseProperty("StopeDevelopments")]
    public virtual Level Level { get; set; }

    [ForeignKey("MineModelId")]
    [InverseProperty("StopeDevelopments")]
    public virtual MineModel MineModel { get; set; }

    [ForeignKey("MiningId")]
    [InverseProperty("StopeDevelopments")]
    public virtual Mining Mining { get; set; }

    [ForeignKey("ShaftId")]
    [InverseProperty("StopeDevelopments")]
    public virtual Shaft Shaft { get; set; }

    [InverseProperty("Stope")]
    public virtual ICollection<UGStopeDetail> UGStopeDetails { get; set; } = new List<UGStopeDetail>();

    [InverseProperty("Stope")]
    public virtual ICollection<UGStopesRaw> UGStopesRaws { get; set; } = new List<UGStopesRaw>();

    [InverseProperty("Stope")]
    public virtual ICollection<UGSurvey> UGSurveys { get; set; } = new List<UGSurvey>();
}