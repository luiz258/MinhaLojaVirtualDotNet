namespace MinhaLojaVirtual.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
            
        }
        public ProductModel(Guid id, string name, double value, string description, bool isActive)
        {
            this.id = id;
            this.name = name;
            this.value = value;
            this.description = description;
            this.isActive = isActive;
        }

        public Guid id { get; set; }
        public string name { get; set; }
        public double value { get; set; }
        public string description { get; set; }
        public bool isActive { get; set; }

        public int quantity { get; set; }


    }
}
