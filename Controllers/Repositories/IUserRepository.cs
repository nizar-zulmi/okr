using System.Collections.Generic;
using okr.Models.Database;

namespace okr.Respositories
{
	public interface IUserRepository
	{
		IEnumerable<User> GetAllUsers();
		void AddUser(User user);
    }
}