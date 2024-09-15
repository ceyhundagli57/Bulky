using System.Reflection.Metadata.Ecma335;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Bulky.DataAccess.Repository;

public class UnitOfWork :  IUnitOfWork
{
    private ApplicationDbContext _db;
    public ICategoryRepository Category { get; private set;}
    public IProductRepository Product { get; private set; }
    public IProductImageRepository ProductImage { get; private set; }

    public ICompanyRepository Company { get; set; }
    public IShoppingCartRepository ShoppingCart { get; set; }
    public IApplicationUserRepository ApplicationUser { get; set; }

    public IOrderHeaderRepository OrderHeader { get; set; }

    public IOrderDetailRepository OrderDetail { get; set; }
    

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        Category = new CategoryRepository(_db);
        Product = new ProductRepository(_db);
        ProductImage = new ProductImageRepository(_db);
        Company = new CompanyRepository(_db);
        ShoppingCart = new ShoppingCartRepository(_db);
        ApplicationUser = new ApplicationUserRepository(_db);
        OrderHeader = new OrderHeaderRepository(_db);
        OrderDetail = new OrderDetailRepository(_db);
    }

    public void Save()
    {
        _db.SaveChanges();
    }
}