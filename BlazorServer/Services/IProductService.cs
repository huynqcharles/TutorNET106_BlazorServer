using Shared;

namespace BlazorServer.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProductById(int id);
        void CreateProduct(Product product);
        void EditProduct(Product product);
        void DeleteProduct(int id);
    }
}
