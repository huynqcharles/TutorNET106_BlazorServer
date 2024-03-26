using Shared;

namespace TutorNET106_BlazorServer.API.Repos
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product);
        void EditProduct(Product product);
        void DeleteProduct(int id);
    }
}
