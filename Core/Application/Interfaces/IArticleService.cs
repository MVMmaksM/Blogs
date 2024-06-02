using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IArticleService
    {
        Task<Article> GetArticleById(int id);
        Task<List<Article>> GetArticles();
        Task<Article> CreateArticle(Article article);
        Task<Article> UpdateArticle(Article article);
        Task<int> DeletArticle(int id);
    }
}
