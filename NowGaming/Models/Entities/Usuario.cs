using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NowGaming.Models.Entities
{
    public class Usuario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(100)]

        public string email { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

    }
}
