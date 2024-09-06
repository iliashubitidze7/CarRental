

namespace CR.DataAccess.Repository.IRepository
{
    public interface IUnitOfwork
    {
        ICarRepository Car {  get; }
        void Save();
    }
}
