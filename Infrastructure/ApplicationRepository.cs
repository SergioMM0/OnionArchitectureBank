using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class ApplicationRepository : IApplicationRepository
{
    public List<User> GetAllUsers()
    {
        return new List<User>{ new User() { Id = 1, Name = "Sergio", Balance = 10 }};
    }
}