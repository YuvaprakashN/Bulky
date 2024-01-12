using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models.Models;
using BulkyBookWeb.Data;


namespace BulkyBook.DataAccess.Repository
{
    public class ShoppingCartRepository : Repositary<ShoppingCart>, IShoppingCartRepository
    {

        private readonly ApplicationDbContext _db;
        public ShoppingCartRepository(ApplicationDbContext db):base(db)
        {
            _db = db;

        }

        void IShoppingCartRepository.Update(ShoppingCart shoppingCart)
        {
          _db.ShoppingCarts.Update(shoppingCart);
        }
    }
}
