﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Entities.Concrete;
using BlogProject.Entities.Dtos.EmailDtos;
using BlogProject.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BlogProject.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly AboutUsPageInfo _aboutUsPageInfo;

        public HomeController(IArticleService articleService, IOptions<AboutUsPageInfo> aboutUsPageInfo)
        {
            _articleService = articleService;
            _aboutUsPageInfo = aboutUsPageInfo.Value;
        }

        [HttpGet]

        public async Task<IActionResult> Index(int? categoryId, int currentPage = 1, int pageSize = 5, bool isAscending = false)
        {
            var articleResult = await (categoryId == null
                ? _articleService.GetAllByPaging(null, currentPage, pageSize, isAscending)
                : _articleService.GetAllByPaging(categoryId.Value, currentPage, pageSize, isAscending));

            return View(articleResult.Data);
        }

        [HttpGet]

        public IActionResult About()
        {
            return View(_aboutUsPageInfo);
        }

        [HttpGet]

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Contact(EmailSendDto emailSendDto)
        {
            return View();
        }
    }
}
