using Shared;
using TutorNET106_BlazorServer.API.Repos;

namespace TutorNET106_BlazorServer.API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public void CreateProduct(Product product)
        {
            _productRepo.CreateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _productRepo.DeleteProduct(id);
        }

        public void EditProduct(Product product)
        {
            _productRepo.EditProduct(product);
        }

        public Product GetProductById(int id)
        {
            return _productRepo.GetProductById(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productRepo.GetProducts();
        }
    }
}
