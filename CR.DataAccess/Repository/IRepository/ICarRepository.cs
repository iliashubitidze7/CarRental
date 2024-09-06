using CR.Models;


namespace CR.DataAccess.Repository.IRepository
{
    public interface ICarRepository : IRepositoryBase<Car>
    {
        public void Update(Car obj);
    }
}
