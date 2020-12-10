using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
        public class Tovar
        {
            [Key]
            public int Id { get; set; }
            [StringLength(500)]
            [Required]
            public string Name { get; set; }
            public int Cost { get; set; }
            [StringLength(500)]
            public string Description { get; set; }
            public string City { get; set; }
            [ForeignKey("Category")]
            public int CategoryId { get; set; }
            public Categories Category { get; set; }
            [ForeignKey("ApplicationUser")]
            public string UserId { get; set; }
            public ApplicationUser ApplicationUser { get; set; }
            public virtual ICollection<Tovar_Image> Images { get; set; }
        }
    }

