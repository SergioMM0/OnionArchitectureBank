using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private IUserService _service;
    public UserController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    public List<User> GetAllUsers()
    {
        return _service.GetAllUsers();
    }
}