using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductApi.Entities
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] //id'nin otomatik ilerlemesini sağlar.
        public int Id { get; set; }
        [Required, StringLength(50)] 
        public string Name { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
    }
}
