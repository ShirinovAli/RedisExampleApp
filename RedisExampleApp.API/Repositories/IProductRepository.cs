using RedisExampleApp.API.Models;

namespace RedisExampleApp.API.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task<Product> AddAsync(Product product);
    }
}
