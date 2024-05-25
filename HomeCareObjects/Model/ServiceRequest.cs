#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HomeCareObjects.Model
{
    public partial class ServiceRequest
    {
        public ServiceRequest()
        {
            Documents = new HashSet<Document>();
        }

        [Key]
        [Column("RequestID")]
        public int RequestId { get; set; }
        [StringLength(1000)]
        public string? RequestDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RequestDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateNeeded { get; set; }
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Column("TechnicianID")]
        public int TechnicianId { get; set; }
        [Column("ServiceID")]
        public int ServiceId { get; set; }

        [ForeignKey("CustomerId")]
        [InverseProperty("ServiceRequestCustomers")]
        public virtual User Customer { get; set; } = null!;
        [ForeignKey("ServiceId")]
        [InverseProperty("ServiceRequests")]
        public virtual Service Service { get; set; } = null!;
        [ForeignKey("TechnicianId")]
        [InverseProperty("ServiceRequestTechnicians")]
        public virtual User Technician { get; set; } = null!;
        [InverseProperty("Request")]
        public virtual ICollection<Document> Documents { get; set; }
    }
}
