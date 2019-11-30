using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ThiGK_30_11.Models
{
    public class PhongBan
    {
        [Key]
        public int MaPB { get; set; }
        [Column("nvarchar(100)")]
        [Required]
        public string TenPB { get; set; }
    }
}
