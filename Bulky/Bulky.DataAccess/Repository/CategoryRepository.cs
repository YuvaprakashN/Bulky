using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBookWeb.Data;


namespace BulkyBook.DataAccess.Repository
{
    public class CategoryRepository : Repositary<Category>, ICategoryRepository
    {

        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db):base(db)
        {
            _db = db;

        }

      

        void ICategoryRepository.Update(Category category)
        {
            _db.Categories.Update(category);
        }
    }
}
