using MinhaLojaVirtual.Models;
using System.Collections.Generic;

namespace MinhaLojaVirtual.Infra.IRepository
{
    public interface IUserRepository
    {
        Task Save(UserModel model);
        Task Update(UserModel model);
        Task<UserModel> GetbyId(Guid id);
        Task<UserModel> GetbyEmail(string email);
        
        Task<IEnumerable<UserModel>> GetAll();


    }
}
