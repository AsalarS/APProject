#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HomeCareObjects.Model
{
    public partial class Comment
    {
        [Key]
        [Column("CommentID")]
        public int CommentId { get; set; }
        [StringLength(500)]
        public string CommentText { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CommentDate { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("RequestID")]
        public int RequestId { get; set; }

        [ForeignKey("RequestId")]
        [InverseProperty("Comments")]
        public virtual ServiceRequest Request { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("Comments")]
        public virtual User User { get; set; } = null!;
    }
}
