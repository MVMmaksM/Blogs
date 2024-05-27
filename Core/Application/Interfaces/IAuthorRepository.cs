using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IAuthorRepository
    {
        Task<Author> Create(Author author);
        Task<Author> GetById(int id);
        Task<Author> Update(Author author);
        Task<Author> Delete(int id);
        Task<List<Author>> GetAuthors();
    }
}
