using React_Ecommerce_BE.BusinessRepository;
using React_Ecommerce_BE.Models;

namespace React_Ecommerce_BE.BusinessLogic
{
    public class ProductBusinessLogic:IProductBusinessLogic
    {
        private readonly IProductsBusinessRepository productBusinessRepository;
        public ProductBusinessLogic(IProductsBusinessRepository _productBusinessRepository)
        {
            productBusinessRepository = _productBusinessRepository;
        }

        public List<Product> getAccessories()
        {
            return productBusinessRepository.getAccessories();
        }

        public List<Product> getAllProducts()
        {
            return productBusinessRepository.getAllProducts();
        }

        public List<Product> getClothes()
        {
            return productBusinessRepository.getClothes();
        }

        public List<Product> getMenProducts()
        {
            return productBusinessRepository.getMenProducts();
        }

        public List<Product> getWomenProducts()
        {
            return productBusinessRepository.getWomenProducts();
        }
    }
}
