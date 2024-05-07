using Microsoft.EntityFrameworkCore;
using MinhaLojaVirtual.Infra.Context;
using MinhaLojaVirtual.Infra.IRepository;
using MinhaLojaVirtual.Models;
using System.Linq;
using System.Linq.Expressions;

namespace MinhaLojaVirtual.Infra.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly dbContextLoja _context;
        public ProductRepository(dbContextLoja context)
        {
            _context = context;
        }

        public Task<IEnumerable<ProductModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> getById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductModel>> GetFilteredProducts(Expression<Func<ProductModel, bool>> filter = null)
        {
            IQueryable<ProductModel> query = _context.Set<ProductModel>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return await query.ToListAsync();
        }

        public async Task Save(ProductModel model)
        {
            await _context.Products.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task Update(ProductModel model)
        {

            _context.Set<ProductModel>().Update(model);
            await _context.SaveChangesAsync();
        }
    }
}
