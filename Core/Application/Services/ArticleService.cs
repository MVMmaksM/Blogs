using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task<Article> GetArticleById(int id) 
        {
            return await _articleRepository.GetById(id);
        }

        public async Task<List<Article>> GetArticles()
        {
           return await _articleRepository.GetArticles();
        }

        public async Task<Article> CreateArticle(Article article)
        {
            return await _articleRepository.Create(article);      
        }

        public async Task<Article> UpdateArticle(Article article)
        {
            var existArticle = await _articleRepository.GetById(article.Id);
            if (existArticle is null)
                throw new Exception();
            return await _articleRepository.Update(article);
        }

        public async Task<int> DeletArticle(int id)
        {
            var existArticle = await _articleRepository.GetById(id);
            if (existArticle is null)
                throw new Exception();
            return await _articleRepository.Delete(id);
        }
    }
}
