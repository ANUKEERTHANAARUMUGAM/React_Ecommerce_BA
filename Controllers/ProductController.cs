using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using React_Ecommerce_BE.BusinessLogic;

namespace React_Ecommerce_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IProductBusinessLogic iProductBusinessLogic;

        public ProductController(IProductBusinessLogic _iProductBusinessLogic)
        {
            iProductBusinessLogic = _iProductBusinessLogic;
        }


        [HttpGet("Get-All-Orders")]
        public IActionResult GetAllProducts()
        {
            var orders = iProductBusinessLogic.getAllProducts();
            return Ok(orders);
        }


        [HttpGet("Get-Women-Orders")]
        public IActionResult GetWomenProducts()
        {
            var orders = iProductBusinessLogic.getWomenProducts();
            return Ok(orders);
        }

        [HttpGet("Get-Men-Orders")]
        public IActionResult GetMenProducts()
        {
            var orders = iProductBusinessLogic.getMenProducts();
            return Ok(orders);
        }



        [HttpGet("Get-Clothes")]
        public IActionResult GetClothes()
        {
            var orders = iProductBusinessLogic.getClothes();
            return Ok(orders);
        }


        [HttpGet("Get-Accessories")]
        public IActionResult GetAccessories()
        {
            var orders = iProductBusinessLogic.getAccessories();
            return Ok(orders);
        }

    }


}
