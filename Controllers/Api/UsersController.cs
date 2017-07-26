using System.Linq;
using Microsoft.AspNetCore.Mvc;
using okr.Models;
using okr.Models.Database;
using okr.Respositories;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace okr.Controllers.Api
{
	[Route("api/users")]
	public class UsersController : Controller
	{
		IUserRepository _repository;
        private readonly DatabaseContext _databaseContext;

		public UsersController(IUserRepository repository, DatabaseContext databaseContext)
		{
			_repository = repository;
            _databaseContext = databaseContext;
		}

		[HttpGet("")]
		public IActionResult Get()
		{
			return Ok(_repository.GetAllUsers());
		}

        // public User Get(string id)
		// {
        //     return _databaseContext.User.FirstOrDefault(x => x.Id == id);
		// }

		[HttpPost("")]
		public void Post([FromBody]User users)
		{
			_databaseContext.Add(users);
            _databaseContext.SaveChanges();
		}
	}
}