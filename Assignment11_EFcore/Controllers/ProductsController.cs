using Microsoft.AspNetCore.Mvc;
using Assignment11_EFcore.DTOs;
using Assignment11_EFcore.Services;

namespace Assignment11_EFcore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<GetProductResponse> GetAll()
        {
            return _productService.GetAll();
        }

        [HttpGet("{id}")]
        public GetProductResponse? GetById(int id)
        {
            return _productService.GetById(id);
        }

        [HttpPost]
        public AddProductResponse? Add([FromBody] AddProductRequest requestModel)
        {
            return _productService.Create(requestModel);
        }

        [HttpPut]
        public UpdateProductResponse? Update([FromBody] UpdateProductRequest requestModel)
        {
            return _productService.Update(requestModel);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _productService.Delete(id);
        }
    }
}