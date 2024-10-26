﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Reconcilor.Domain.Models;

[Table("Shaft")]
public partial class Shaft
{
    [Key]
    public int ShaftId { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string ShaftName { get; set; }

    [InverseProperty("Shaft")]
    public virtual ICollection<BeltsRaw> BeltsRaws { get; set; } = new List<BeltsRaw>();

    [InverseProperty("Shaft")]
    public virtual ICollection<Level> Levels { get; set; } = new List<Level>();

    [InverseProperty("Shaft")]
    public virtual ICollection<StopeDefinition> StopeDefinitions { get; set; } = new List<StopeDefinition>();

    [InverseProperty("Shaft")]
    public virtual ICollection<UGSurvey> UGSurveys { get; set; } = new List<UGSurvey>();
}