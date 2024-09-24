using CR.DataAccess.Data;
using CR.DataAccess.Repository.IRepository;
using CR.Models;


namespace CR.DataAccess.Repository
{
    public class ApplicationUser : RepositoryBase<ApplicationUser> , IApplicationUserRepository
    {
        private ApplicationDbContext db;

        public ApplicationUser(ApplicationDbContext db) : base(db) 
        {
            this.db = db;
        }
    }
}
