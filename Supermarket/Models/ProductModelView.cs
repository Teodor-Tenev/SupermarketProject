using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Supermarket.DAL;

namespace Supermarket.Models
{
    public class ProductModelView
    {
        #region Properties

        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Quantity { get; set; }
        public string CategoryName { get; set; }
        public string ManifactorName { get; set; }
        public int Id { get; set; }

        #endregion //Properties

        #region Constructors

        /// <summary>
        /// Constructor with all properties
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
        /// <param name="categoryName"></param>
        /// <param name="manifactorName"></param>
        public ProductModelView(string name, decimal price, float quantity, string categoryName, string manifactorName, int id)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.CategoryName = categoryName;
            this.ManifactorName = manifactorName;
            this.Id = id;
        }

        public ProductModelView(Product product)
        {
            
            this.Name = product.Name;
            this.Price = product.Price;
            this.Quantity = product.Quantity;

            foreach (Category category in CategoryDAL.GetAllCategories())
            {
                if (product.CategoryId == category.CategoryId)
                {
                    this.CategoryName += category.Name + " ";
                }
            }  
          
           
            this.ManifactorName = product.Manifactor.Name;
            this.Id = product.ProductId;
        }

        #endregion //Constructors

    }
}
