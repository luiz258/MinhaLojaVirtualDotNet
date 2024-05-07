using Microsoft.EntityFrameworkCore;
using MinhaLojaVirtual.Infra.Context;
using MinhaLojaVirtual.Infra.IRepository;
using MinhaLojaVirtual.Models;

namespace MinhaLojaVirtual.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly dbContextLoja _context;
        public UserRepository(dbContextLoja context)
        {
            _context = context;
        }

        public Task<IEnumerable<UserModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetbyEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<UserModel> GetbyId(Guid id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.id == id);
        }

        public async Task Save(UserModel model)
        {
           await _context.Users.AddAsync(model);
           await _context.SaveChangesAsync();
        }

        public async Task Update(UserModel model)
        {
            _context.Set<UserModel>().Update(model);
            await _context.SaveChangesAsync();
        }
    }
}
