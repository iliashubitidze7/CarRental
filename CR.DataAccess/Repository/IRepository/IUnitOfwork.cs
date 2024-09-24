

namespace CR.DataAccess.Repository.IRepository
{
    public interface IUnitOfwork
    {
        ICarRepository Car {  get; }
        IApplicationUserRepository ApplicationUser { get; }
        void Save();
    }
}
