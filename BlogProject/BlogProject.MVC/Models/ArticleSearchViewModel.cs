using System;
using BlogProject.Entities.Dtos.ArticleDtos;

namespace BlogProject.MVC.Models
{
	public class ArticleSearchViewModel
	{
        public ArticleListDto ArticleListDto { get; set; }

        public string Keyword { get; set; }
    }
}       

