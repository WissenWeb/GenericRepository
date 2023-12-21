using GenericRepository.Context;
using GenericRepository.GenericRepository;
using GenericRepository.UnitOfWork;

namespace GenericRepository.Services
{
    public class UserService:IUserService
    {
        //public IRepository<User> _repository { get; set; }
        //public UserService(IRepository<User> repository)
        //{
        //    _repository = repository;

        //}
        public UnitOfWork.UnitOfWork _unitofWork;
        public UserService(UnitOfWork.UnitOfWork unitofWork)
        {
            _unitofWork = unitofWork;
        }
        public void AddUser(User user)
        {
            _unitofWork.UserRepository.Add(user);
            _unitofWork.Commit();
        }
    }
    public interface IUserService
    {
        public void AddUser(User user);


    }
}
