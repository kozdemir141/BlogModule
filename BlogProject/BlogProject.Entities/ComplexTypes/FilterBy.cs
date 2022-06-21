using System;
namespace BlogProject.Entities.ComplexTypes
{
	public enum FilterBy
	{
		Category = 0, // GetAllByUserId(FilterBy = FilterBy.Category, int categoryId)
		Date = 1,
		ViewCount = 2,
		CommentCount = 3
	}
}

