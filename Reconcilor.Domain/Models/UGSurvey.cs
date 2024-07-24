﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Reconcilor.Domain.Models;

[Table("UGSurvey")]
public partial class UGSurvey
{
    [Key]
    public int Id { get; set; }

    public int ShaftId { get; set; }

    public int LevelId { get; set; }

    public int StopeId { get; set; }

    public int ModelId { get; set; }

    public int SurveyorId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SurveyDate { get; set; }

    public int Volume { get; set; }

    public int Density { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TCu { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TCo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Cu { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Co { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string FileLocation { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string EnteredBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EnteredOn { get; set; }

    [ForeignKey("LevelId")]
    [InverseProperty("UGSurveys")]
    public virtual Level Level { get; set; }

    [ForeignKey("ModelId")]
    [InverseProperty("UGSurveys")]
    public virtual MineModel Model { get; set; }

    [ForeignKey("ShaftId")]
    [InverseProperty("UGSurveys")]
    public virtual Shaft Shaft { get; set; }

    [ForeignKey("StopeId")]
    [InverseProperty("UGSurveys")]
    public virtual StopeDevelopment Stope { get; set; }
}