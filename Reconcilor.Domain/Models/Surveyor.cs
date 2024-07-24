﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Reconcilor.Domain.Models;

[Table("Surveyor")]
public partial class Surveyor
{
    [Key]
    public int Id { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string EmployeeCode { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string LastName { get; set; }

    public bool IsActive { get; set; }
}