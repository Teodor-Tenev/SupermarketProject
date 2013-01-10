using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Supermarket.DAL;

namespace Supermarket.Models
{
    public class CategoryModelView
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int? ParentId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        public CategoryModelView(string name, int categoryId, int? parentId=null)
        {
            this.Name = name;
            this.CategoryId = categoryId;
            this.ParentId = parentId;
        }

        public CategoryModelView(Category category )
        {
            this.Name = category.Name;
            this.CategoryId = category.CategoryId;
            this.ParentId = category.ParentId;
        }
    }
}