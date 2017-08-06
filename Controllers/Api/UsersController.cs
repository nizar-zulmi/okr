using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using okr.Models;
using okr.Models.Database;
using okr.Models.ViewModel;
using okr.Respositories;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace okr.Controllers.Api
{
	[Route("api/users")]
	public class UsersController : Controller
	{
		IUserRepository _repository;
        private readonly DatabaseContext _databaseContext;
		private ILogger _logger;

		public UsersController(IUserRepository repository, DatabaseContext databaseContext, ILogger<UserController> logger)
		{
			_repository = repository;
            _databaseContext = databaseContext;
			_logger = logger;
		}

		[HttpGet("")]
		public IActionResult Get()
		{
			try
			{
				var result = _repository.GetAllUsers();
				return Ok(Mapper.Map<IEnumerable<UserViewModel>>(result));
			}
			catch (Exception ex)
			{
				_logger.LogError($"Failed to get all users by api: {ex}");
				return BadRequest("Error occured");
			}

			//return Ok(_repository.GetAllUsers());
		}

		[HttpPost("")]
		public IActionResult Post([FromBody]UserViewModel theUser)
		{
			if (ModelState.IsValid)
			{
				var newUser = Mapper.Map<User>(theUser);
				_repository.AddUser(newUser);

				return Created($"api/users/{theUser.FirstName}", Mapper.Map<UserViewModel>(newUser));
			}
			else
			{
				return BadRequest("Failed to save user");
			}
		}

		// [HttpGet("")]
        // public User Get(string id)
		// {
        //     return _databaseContext.User.FirstOrDefault(x => x.Id == id);
		// }

		// [HttpPost("")]
		// public void Post([FromBody]User users)
		// {
		// 	_databaseContext.Add(users);
        //     _databaseContext.SaveChanges();
		// }
	}
}