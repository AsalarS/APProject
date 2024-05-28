#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HomeCareObjects.Model
{
    public partial class Log
    {
        [Key]
        [Column("LogID")]
        public int LogId { get; set; }
        [StringLength(50)]
        public string Source { get; set; } = null!;
        [StringLength(50)]
        public string Type { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        [StringLength(50)]
        public string Message { get; set; } = null!;
        public string OriginalValues { get; set; } = null!;
        public string CurrentValues { get; set; } = null!;
        [Column("UserID")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Logs")]
        public virtual User User { get; set; } = null!;
    }
}
