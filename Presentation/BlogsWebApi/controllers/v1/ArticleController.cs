using Microsoft.AspNetCore.Mvc;
using Application.Services;

namespace BlogsWebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ArticleController : BaseApiController
    {
        private readonly ArticleService _articleService;

        public ArticleController(ArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            return Ok(await _articleService.GetArticles());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticle(int id) 
        {
            return Ok(await _articleService.GetArticleById(id));
        }
    }
}
