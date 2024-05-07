using MinhaLojaVirtual.Models;
using System.Linq.Expressions;

namespace MinhaLojaVirtual.Infra.IRepository
{
    public interface IProductRepository
    {
        Task Save(ProductModel model);
        Task Update(ProductModel model);
        Task<ProductModel> getById(Guid id);
        Task<IEnumerable<ProductModel>> GetAll();
        Task<IEnumerable<ProductModel>> GetFilteredProducts(Expression<Func<ProductModel, bool>> filter = null);
    }
}
