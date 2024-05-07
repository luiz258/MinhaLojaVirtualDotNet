using MinhaLojaVirtual.Models;

namespace MinhaLojaVirtual.Infra.IRepository
{
    public interface IProductRepository
    {
        Task Save();
        Task Update();
        Task<ProductModel> getById(Guid id);
        //Task IEnumerable<ProductModel> ListAll();
    }
}
