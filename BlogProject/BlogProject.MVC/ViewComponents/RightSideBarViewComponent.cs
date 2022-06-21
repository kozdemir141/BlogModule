using System;
using System.Threading.Tasks;
using BlogProject.MVC.Models;
using BlogProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.MVC.ViewComponents
{
    public class RightSideBarViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IArticleService _articleService;

        public RightSideBarViewComponent(ICategoryService categoryService, IArticleService articleService)
        {
            _categoryService = categoryService;
            _articleService = articleService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoriesResult = await _categoryService.GetAllByNonDeletedAndActive();
            var articlesResult = await _articleService.GetAllByViewCount(isAscending: false, takesize: 5);

            return View(new RightSideBarViewModel
            {
                Categories = categoriesResult.Data.Categories,
                Articles = articlesResult.Data.Articles
            });
        }
    }
}

