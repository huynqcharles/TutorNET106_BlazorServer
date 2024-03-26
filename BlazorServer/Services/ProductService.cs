using Shared;

namespace BlazorServer.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductById(int id)
        {
            var product = await _httpClient.GetFromJsonAsync<Product>($"api/Products/id:int?id={id}");
            return product;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var products = await _httpClient.GetFromJsonAsync<IEnumerable<Product>>("api/Products");
            return products;
        }
    }
}
