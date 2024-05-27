using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IArticleRepository
    {
        Task<Article> Create(Article article);
        Task<Article> Update(Article article);
        Task<Article> GetById(int id);
        Task<int> Delete(int id);
        Task<List<Article>> GetArticles();
    }
}
