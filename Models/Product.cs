namespace React_Ecommerce_BE.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public bool InCart { get; set; }
        public string Category { get; set; }
    }
}
/*
 id: 1,
    name: "Brown Shirt",
    description: "Brown T-Shirt for Women",
    price: 16.99,
    gender: "women",
    type: "shirt",
    img: "https://image.ibb.co/kOhL6k/img1.jpg",
    inCart: false,
    category: "clothes"
 */
