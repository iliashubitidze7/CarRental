using CR.DataAccess.Data;
using CR.DataAccess.Repository.IRepository;


namespace CR.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfwork
    {
        private ApplicationDbContext db;
        public ICarRepository Car { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            this.db = db;
            Car = new CarRepository(db);
            ApplicationUser = new ApplicationUser(db);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
