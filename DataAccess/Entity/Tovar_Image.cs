using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entity
{
    public class Tovar_Image
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        [Required]
        public string Image { get; set; }
        [ForeignKey("Tovar")]
        public int TovarId { get; set; }
        public Tovar Tovar { get; set; }
    }
}