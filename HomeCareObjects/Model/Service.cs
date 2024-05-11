using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HomeCareObjects.Model
{
    public partial class Service
    {
        public Service()
        {
            ServiceRequests = new HashSet<ServiceRequest>();
            Technicians = new HashSet<User>();
        }

        [Key]
        [Column("ServiceID")]
        public int ServiceId { get; set; }
        [StringLength(50)]
        public string ServiceName { get; set; } = null!;
        [StringLength(500)]
        public string? ServiceDescription { get; set; }
        [Column(TypeName = "money")]
        public decimal ServicePrice { get; set; }
        [Column("CategoryID")]
        public int CategoryId { get; set; }
        [Column("TechnicianID")]
        public int TechnicianId { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("Services")]
        public virtual Category Category { get; set; } = null!;
        [ForeignKey("TechnicianId")]
        [InverseProperty("Services")]
        public virtual User Technician { get; set; } = null!;
        [InverseProperty("Service")]
        public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }

        [ForeignKey("ServiceId")]
        [InverseProperty("ServicesNavigation")]
        public virtual ICollection<User> Technicians { get; set; }
    }
}
