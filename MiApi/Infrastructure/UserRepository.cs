using Domain.Interfaces;
using Domain.Entities;

namespace Infrastructure
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAll()
        {
            return AplicationDbContext.Users;
        }
    }
}
