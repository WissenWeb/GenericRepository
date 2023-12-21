using GenericRepository.Context;
using GenericRepository.GenericRepository;


namespace GenericRepository.UnitOfWork
{
    public class UnitOfWork 
    {

        UserContext _userContext;
        public IRepository<User> UserRepository { get;  set; }

        public UnitOfWork(UserContext usercontext)
        {
            
            _userContext = usercontext;
            UserRepository = new Repository<User>(_userContext);
        }

        public void Commit()
        {
            using (var transaction =_userContext.Database.BeginTransaction())
            {
                try
                {
                    _userContext.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {

                    transaction.Rollback();
                }
            }
        }
    }
    //public interface IUnitOfWork
    //{

    //    public int Commit();
        
    //}
}
