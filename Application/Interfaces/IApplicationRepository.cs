using Domain;

namespace Application.Interfaces;

public interface IApplicationRepository
{
    public List<User> GetAllUsers();
}