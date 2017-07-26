using okr.Models.Database;
using okr.Models.ViewModel;

namespace okr.Mappers
{
    public static class UserViewModelMapper
    {
        public static UserViewModel MapFrom(User user)
        {
            return new UserViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
        }
    }
}