using CR.DataAccess.Data;
using CR.DataAccess.Repository.IRepository;
using CR.Models;


namespace CR.DataAccess.Repository
{
    public class CarRepository : RepositoryBase<Car> , ICarRepository
    {
        private ApplicationDbContext db;

        public CarRepository(ApplicationDbContext db) : base(db) 
        {
            this.db = db;
        }

        public void Update(Car obj)
        {
            db.Cars.Update(obj);
        }
    }
}
