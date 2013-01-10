using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supermarket.DAL
{
    public static class CategoryDAL
    {
       static private SupermarketEntities db = new SupermarketEntities();

        public static List<Category> GetAllCategories()
        {
             return db.Categories.ToList();
        }

        public static void AddCategories(string name,int? parentId=null)
        {
            db.Categories.AddObject(new Category {Name =name, ParentId = parentId});
            db.SaveChanges();
        }

        public static void AddCategories(Category category)
        {
            db.Categories.AddObject(category);
            db.SaveChanges();
        }
    }
}
