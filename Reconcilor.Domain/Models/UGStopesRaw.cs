﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Reconcilor.Domain.Models;

[Table("UGStopesRaw")]
public partial class UGStopesRaw
{
    [Key]
    public int Id { get; set; }

    public int ShaftId { get; set; }

    public int LevelId { get; set; }

    public int ShiftId { get; set; }

    public int StopeId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateEntered { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TicketNo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Tonnes { get; set; }

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
    public string Comment { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string EnteredBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EnteredOn { get; set; }

    [ForeignKey("LevelId")]
    [InverseProperty("UGStopesRaws")]
    public virtual Level Level { get; set; }

    [ForeignKey("ShaftId")]
    [InverseProperty("UGStopesRaws")]
    public virtual Shaft Shaft { get; set; }

    [ForeignKey("ShiftId")]
    [InverseProperty("UGStopesRaws")]
    public virtual Shift Shift { get; set; }

    [ForeignKey("StopeId")]
    [InverseProperty("UGStopesRaws")]
    public virtual StopeDevelopment Stope { get; set; }
}