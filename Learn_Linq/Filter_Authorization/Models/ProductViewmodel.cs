using System.ComponentModel.DataAnnotations;

namespace Filter_Authorization.Models
{
    public class ProductViewmodel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Price { get; set; }
    }
}
