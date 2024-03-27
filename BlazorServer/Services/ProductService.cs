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

        public async Task CreateProduct(Product product)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Products", product);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
        }

        public async Task DeleteProduct(int id)
        {
            await _httpClient.DeleteAsync($"api/Products/id:int?id={id}");
        }

        public async Task EditProduct(Product product)
        {
            await _httpClient.PutAsJsonAsync("api/Products", product);
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
