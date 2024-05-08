using System.ComponentModel.DataAnnotations;

namespace MinhaLojaVirtual.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
            
        }
        public ProductModel(string name, double value,  int quantity, string description)
        {
            this.id = new Guid();
            this.name = name;
            this.value = value;
            this.quantity = quantity;
            this.description = description;
            this.isActive = true;
        }

        public Guid id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public double value { get; set; }

        [Required]
        public string description { get; set; }

        [Required]
        public bool isActive { get; set; }

        [Required]
        public int quantity { get; set; }


    }
}
