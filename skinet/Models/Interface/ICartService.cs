using skinet.Models.Entities;

namespace skinet.Models.Interface
{
    public interface ICartService
    {
        Task <ShoppingCart?> GetCartAsync(string key);
        Task<ShoppingCart?> SetCartAsync(ShoppingCart cart);
        Task<bool> DeleteCartAsync(string key);
    }
}
