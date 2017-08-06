using System.Collections.Generic;
using System.Linq;
using okr.Models.Database;

namespace okr.Respositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _databaseContext;

        public UserRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public User GetByEmail(string email)
        {
            return _databaseContext.User.SingleOrDefault(x => x.Email == email);
        }

        public void Save(User user)
        {
            var userFromDb = _databaseContext.User.SingleOrDefault(x => x.Id == user.Id);
            if(userFromDb != null)
            {
                userFromDb = user;
            }
            else
            {
                _databaseContext.User.Add(user);
            }
            _databaseContext.SaveChanges();
        }

        public IEnumerable<User> GetAllUsers()
		{
			return _databaseContext.User.ToList();
		}

        public void AddUser(User user)
        {
            _databaseContext.Add(user);
            _databaseContext.SaveChanges();
        }
    }
}