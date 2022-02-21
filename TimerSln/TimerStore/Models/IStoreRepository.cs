using System.Linq;

namespace TimerStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }

}
