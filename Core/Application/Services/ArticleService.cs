using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ArticleService
    {
        private readonly IArticleRepository _articleRepository;
        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public async Task GetArticleById(int id) 
        {
             await _articleRepository.GetById(id);
        }

        public async Task GetArticles()
        {
            await _articleRepository.GetArticles();
        }

        public async Task CreateArticle(Article article)
        {
            await _articleRepository.Create(article);      
        }

        public async Task UpdateArticle(Article article)
        {
            var existArticle = await _articleRepository.GetById(article.Id);
            if (existArticle is null)
                throw new Exception();
            await _articleRepository.Update(article);
        }

        public async Task DeletArticle(int id)
        {
            var existArticle = await _articleRepository.GetById(id);
            if (existArticle is null)
                throw new Exception();
            await _articleRepository.Delete(id);
        }
    }
}
