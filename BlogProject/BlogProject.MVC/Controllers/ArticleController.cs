using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Entities.ComplexTypes;
using BlogProject.MVC.Models;
using BlogProject.Services.Abstract;
using BlogProject.Shared.Utilities.Results.ComplexTypes;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.MVC.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet]
        public async Task<IActionResult> Search(string keyword, int currentPage = 1, int pageSize = 5, bool isAscending = false)
        {
            var result = await _articleService.Search(keyword, currentPage, pageSize, isAscending);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(new ArticleSearchViewModel
                {
                    ArticleListDto = result.Data,
                    Keyword = keyword
                });
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int articleId)
        {
            var articleResult = await _articleService.Get(articleId);

            if (articleResult.ResultStatus == ResultStatus.Success)
            {
                var userArticles = await _articleService.GetAllByUserIdOnFilter(articleResult.Data.Article.UserId, FilterBy.Category, OrderBy.Date, false, 10, articleResult.Data.Article.CategoryId, DateTime.Now, DateTime.Now, 0, 99999, 0, 99999);
                await _articleService.IncreaseViewCount(articleId);
                return View(new ArticleDetailViewModel
                {
                    ArticleDto = articleResult.Data,
                    ArticleDetailRightSideBarViewModel = new ArticleDetailRightSideBarViewModel
                    {
                        ArticleListDto = userArticles.Data,
                        User = articleResult.Data.Article.User,
                        Header = "User's Most Read Articles In The Same Category"
                    }
                });
            }
            return NotFound();
        }
    }
}

