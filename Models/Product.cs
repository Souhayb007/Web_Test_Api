using System.ComponentModel.DataAnnotations;

namespace Web_Test_Api.Model
{
    public class Product
    {
        [Key]
        public int barcode { get; set; }
        public string categorie { get; set; }
        public int discount { get; set; }
        public string name { get; set; }
    }
}
