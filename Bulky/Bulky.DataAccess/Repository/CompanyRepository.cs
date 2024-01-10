using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Models.Models;
using BulkyBookWeb.Data;


namespace BulkyBook.DataAccess.Repository
{
    public class CompanyRepository : Repositary<Company>, ICompanyRepository
    {

        private readonly ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db):base(db)
        {
            _db = db;

        }

      

      

        void ICompanyRepository.Update(Company company)
        {
           _db.Companies.Update(company);
        }
    }
}
