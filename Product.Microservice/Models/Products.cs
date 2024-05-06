namespace Product.Microservice.Models
{
    public class Products
    {
        public int Product_ID { get; set; }
        public int Category_ID { get; set; }
        public string Product_Name { get; set; } = string.Empty;
        public string Product_Description { get; set; } = string.Empty;
        public decimal Product_Price { get; set; }
        public string Image_URL { get; set; } = string.Empty;
        public string Product_Color { get; set; } = string.Empty;
        public string Product_Size { get; set; } = string.Empty;
    }
}
