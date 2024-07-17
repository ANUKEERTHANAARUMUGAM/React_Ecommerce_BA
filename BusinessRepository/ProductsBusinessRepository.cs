using React_Ecommerce_BE.Models;

namespace React_Ecommerce_BE.BusinessRepository
{
    public class ProductsBusinessRepository : IProductsBusinessRepository
    {
        private readonly AppDbContext _context;
        public ProductsBusinessRepository(AppDbContext context)
        {

            _context = context;

        }


        public List<Product> getAllProducts()
        {
            return _context.Products.ToList();
        }

        public List<Product> getWomenProducts()
        {
            List<Product> products = new List<Product>();
            products = _context.Products.Where(product => product.Gender == "women").ToList();
            return products;
        }

        public List<Product> getMenProducts()
        {
            List<Product> products = new List<Product>();
            products = _context.Products.Where(product => product.Gender == "men").ToList();
            return products;
        }

        public List<Product> getClothes()
        {
            List<Product> products = new List<Product>();
            products = _context.Products.Where(product => product.Category == "clothes").ToList();
            return products;
        }

        public List<Product> getAccessories()
        {
            List<Product> products = new List<Product>();
            products = _context.Products.Where(product => product.Category == "accessories").ToList();
            return products;
        }

    }
}
