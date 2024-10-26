using Microsoft.EntityFrameworkCore;
using Reconcilor.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reconcilor.Domain.ViewModels
{
    public class StockPileViewModel
    {
        [Key]
        public int Id { get; set; }

        public int StockPId { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal OpeningTonnes { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal ClosingTonnes { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateFrom { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateTo { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string EnteredBy { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? EnteredOn { get; set; }

        [StringLength(150)]
        [Unicode(false)]
        public string BinName { get; set; }
    }
}
