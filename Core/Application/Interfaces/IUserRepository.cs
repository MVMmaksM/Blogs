using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Create(User user);
        Task<User> GetById(int id);
        Task<bool> IsAccessCredential(User user);
    }
}
