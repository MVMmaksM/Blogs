using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using AutoMapper;
using BlogsWebApi.Contracts.Responce;

namespace BlogsWebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ArticleController : BaseApiController
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public ArticleController(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            return Ok(await _articleService.GetArticles());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticle(int id) 
        {
            var articleResponce = _mapper.Map<ArticleResponce>(await _articleService.GetArticleById(id));
            return Ok(articleResponce);
        }
    }
}
