using MinhaLojaVirtual.Infra.IRepository;
using MinhaLojaVirtual.Models;

namespace MinhaLojaVirtual.Infra.Repository
{
    public class ProductRepository: IProductRepository
    {
        public ProductRepository()
        {
                
        }

        public Task<ProductModel> getById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public Task Update()
        {
            throw new NotImplementedException();
        }
    }
}
