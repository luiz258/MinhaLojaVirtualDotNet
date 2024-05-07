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

        public async Task Save(UserModel user)
        {
           await _context.Users.AddAsync(user);
           await _context.Users.SaveChange''Async();
        }

        public async Task Update(UserModel user)
        {
            await _context.Users.Update(user);
            await _context.Users.SaveChange();
        }
    }
}
