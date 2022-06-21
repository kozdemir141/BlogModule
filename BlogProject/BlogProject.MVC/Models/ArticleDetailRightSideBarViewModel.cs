using System;
using BlogProject.Entities.Concrete;
using BlogProject.Entities.Dtos.ArticleDtos;

namespace BlogProject.MVC.Models
{
	public class ArticleDetailRightSideBarViewModel
	{
        public string Header { get; set; }

        public ArticleListDto ArticleListDto { get; set; }

        public User User { get; set; }
    }   
}

