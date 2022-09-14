using Application.Interfaces;
using Domain;
using Domain.Interfaces;

namespace Application;

public class ApplicationService : IUserService
{
    private IApplicationRepository _repository;
    
    public ApplicationService(IApplicationRepository repository)
    {
        _repository = repository;
    }

    public List<User> GetAllUsers()
    {
        return _repository.GetAllUsers();
    }
}