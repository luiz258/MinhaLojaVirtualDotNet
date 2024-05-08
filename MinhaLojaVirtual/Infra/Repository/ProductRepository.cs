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

        public async Task<IEnumerable<ProductModel>> GetFilteredProducts(int quantity = 0, double value = 0, string name = null)
        {
            IQueryable<ProductModel> query = _context.Set<ProductModel>();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.name.Contains(name));
            }

            if (value>0)
            {
                query = query.Where(p => p.value == value);
            }

            if (quantity > 0)
            {
                query = query.Where(p => p.quantity == quantity);
            }

            return await query.Take(10).ToListAsync();
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
