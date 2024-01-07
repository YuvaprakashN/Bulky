using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBookWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository : Repositary<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        void IProductRepository.Update(Product product)
        {
            Product? productDb = _db.Products.FirstOrDefault(p => p.Id == product.Id);

            if (productDb != null)
            {
                productDb.Title = product.Title;
                productDb.ISBN=product.ISBN;
                productDb.Author = product.Author;
                productDb.Description = product.Description;
                productDb.CategoryId=product.CategoryId;
                productDb.ISBN = product.ISBN;
                productDb.Price = product.Price;
                productDb.Price50 = product.Price50;
                productDb.ListPrice = product.ListPrice;
                productDb.Price100 = product.Price100;
                if(product.ImageURL!= null)
                {
                    productDb.ImageURL= product.ImageURL;
                }
            }

           _db.Products.Update(productDb);
        }
    }
}
