using Shared;

namespace BlazorServer.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProductById(int id);
        Task CreateProduct(Product product);
        Task EditProduct(Product product);
        Task DeleteProduct(int id);
    }
}
