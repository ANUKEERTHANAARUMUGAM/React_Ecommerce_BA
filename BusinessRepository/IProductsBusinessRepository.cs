using React_Ecommerce_BE.Models;

namespace React_Ecommerce_BE.BusinessRepository
{
    public interface IProductsBusinessRepository
    {
        List<Product> getAllProducts();
        List<Product> getWomenProducts();

        List<Product> getClothes();
        List<Product> getMenProducts();

        List<Product> getAccessories();
    }
}
