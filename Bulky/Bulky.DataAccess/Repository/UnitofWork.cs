﻿using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBookWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class UnitofWork : IUnitOfWork
    {
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }

        private readonly ApplicationDbContext _db;
        public UnitofWork(ApplicationDbContext db) 
        {
            _db = db;
            Category = new CategoryRepository(db);
            Product = new ProductRepository(db);
            Company = new CompanyRepository(db);
            ShoppingCart=new ShoppingCartRepository(db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
