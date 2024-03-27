using Shared;
using TutorNET106_BlazorServer.API.Data;

namespace TutorNET106_BlazorServer.API.Repos
{
    public class ProductRepo : IProductRepo
    {
        private readonly MyDbContext _dbContext;

        public ProductRepo(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateProduct(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var productDelete = _dbContext.Products.FirstOrDefault(p => p.ID == id);

            if (productDelete != null)
            {
                _dbContext.Products.Remove(productDelete);
                _dbContext.SaveChanges();
            }
        }

        public void EditProduct(Product product)
        {
            var productUpdate = _dbContext.Products.FirstOrDefault(p => p.ID == product.ID);
            if (productUpdate != null)
            {
                productUpdate.Name = product.Name;
                productUpdate.Description = product.Description;
                productUpdate.Price = product.Price;
                productUpdate.ImagePath = product.ImagePath;

                _dbContext.SaveChanges();
            }
        }

        public Product GetProductById(int id)
        {
            var product = _dbContext.Products.FirstOrDefault(p => p.ID == id);
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = _dbContext.Products;
            return products;
        }
    }
}
