using React_Ecommerce_BE.Models;

namespace React_Ecommerce_BE.BusinessLogic
{
    public interface IProductBusinessLogic
    {
        List<Product> getAllProducts();
        List<Product> getWomenProducts();

        List<Product> getMenProducts();

        List<Product> getClothes();

        List<Product> getAccessories();
    }
}
