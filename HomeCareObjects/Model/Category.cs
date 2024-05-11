using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HomeCareObjects.Model
{
    public partial class Category
    {
        public Category()
        {
            Services = new HashSet<Service>();
        }

        [Key]
        [Column("CategoryID")]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; } = null!;
        [StringLength(1000)]
        public string? Description { get; set; }
        [Column("ManagerID")]
        public int ManagerId { get; set; }

        [ForeignKey("ManagerId")]
        [InverseProperty("Categories")]
        public virtual User Manager { get; set; } = null!;
        [InverseProperty("Category")]
        public virtual ICollection<Service> Services { get; set; }
    }
}
