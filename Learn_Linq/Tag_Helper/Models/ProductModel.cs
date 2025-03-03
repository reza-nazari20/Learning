using System.ComponentModel;

namespace Tag_Helper.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [DisplayName("نام محصول")]
        public string Name { get; set; }
    }
}
