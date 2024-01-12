using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.Models;
using BulkyBookWeb.Data;
using System.Linq.Expressions;

namespace BulkyBook.DataAccess.Repository
{
    public class ApplicationUserRepository : Repositary<ApplicationUser>, IApplicationUserRepository
    {

        private readonly ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db):base(db)
        {
            _db = db;

        }

    }
}
