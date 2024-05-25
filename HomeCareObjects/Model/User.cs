using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HomeCareObjects.Model
{
    public partial class User
    {
        public User()
        {
            Categories = new HashSet<Category>();
            Documents = new HashSet<Document>();
            Logs = new HashSet<Log>();
            Notifications = new HashSet<Notification>();
            ServiceRequestCustomers = new HashSet<ServiceRequest>();
            ServiceRequestTechnicians = new HashSet<ServiceRequest>();
            Services = new HashSet<Service>();
            ServicesNavigation = new HashSet<Service>();
        }

        [Key]
        [Column("UserID")]
        public int UserId { get; set; }
        [StringLength(50)]
        public string Username { get; set; } = null!;
        [StringLength(50)]
        public string Password { get; set; } = null!;
        [StringLength(50)]
        public string Email { get; set; } = null!;
        [StringLength(50)]
        public string UserRole { get; set; } = null!;
        [StringLength(50)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        public string? LastName { get; set; }

        [InverseProperty("Manager")]
        public virtual ICollection<Category> Categories { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Document> Documents { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Log> Logs { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Notification> Notifications { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<ServiceRequest> ServiceRequestCustomers { get; set; }
        [InverseProperty("Technician")]
        public virtual ICollection<ServiceRequest> ServiceRequestTechnicians { get; set; }
        [InverseProperty("Technician")]
        public virtual ICollection<Service> Services { get; set; }

        [ForeignKey("TechnicianId")]
        [InverseProperty("Technicians")]
        public virtual ICollection<Service> ServicesNavigation { get; set; }
    }
}
