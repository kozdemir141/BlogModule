using System;
using System.Collections.Generic;
using BlogProject.Entities.Concrete;

namespace BlogProject.MVC.Models
{
	public class RightSideBarViewModel
	{
        public IList<Category> Categories { get; set; }

        public IList<Article> Articles { get; set; }
    }
}

