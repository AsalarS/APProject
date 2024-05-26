#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HomeCareObjects.Model
{
    public partial class Document
    {
        [Key]
        [Column("DocumentID")]
        public int DocumentId { get; set; }
        [StringLength(200)]
        public string DocumentName { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UploadDate { get; set; }
        [StringLength(50)]
        public string DocumentType { get; set; } = null!;
        [StringLength(200)]
        public string DocumentPath { get; set; } = null!;
        [Column("RequestID")]
        public int RequestId { get; set; }

        [ForeignKey("RequestId")]
        [InverseProperty("Documents")]
        public virtual ServiceRequest Request { get; set; } = null!;
    }
}
