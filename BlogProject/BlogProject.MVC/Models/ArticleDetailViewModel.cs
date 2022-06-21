using System;
using BlogProject.Entities.Dtos.ArticleDtos;

namespace BlogProject.MVC.Models
{
	public class ArticleDetailViewModel
	{
        //Using Model in Article Detail because We using RightSideBar on Partial View.
        //We have to call Model in ArticleDetail Page For call Models in Partial View
        public ArticleDto ArticleDto { get; set; } 

        public ArticleDetailRightSideBarViewModel ArticleDetailRightSideBarViewModel { get; set; }
    }
}

    