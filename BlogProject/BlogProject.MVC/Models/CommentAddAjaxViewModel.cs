﻿using System;
using BlogProject.Entities.Dtos.CommentDtos;

namespace BlogProject.MVC.Models
{
	public class CommentAddAjaxViewModel
	{
        public CommentAddDto CommentAddDto { get; set; }

        public string CommentAddPartial { get; set; }

        public CommentDto CommentDto { get; set; }
    }
}

