#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HomeCareObjects.Model
{
    [Keyless]
    public partial class Comment
    {
        [Column("CommentID")]
        public int CommentId { get; set; }
        [StringLength(500)]
        public string CommentText { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CommentDate { get; set; }
        public byte[] CommentTime { get; set; } = null!;
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("RequestID")]
        public int RequestId { get; set; }

        [ForeignKey("RequestId")]
        public virtual ServiceRequest Request { get; set; } = null!;
        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!;
    }
}
