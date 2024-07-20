using AutoMapper;
using AutoMapperDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    IMapper _mapper;

    public UserController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpGet("")]
    public ActionResult GetUser()
    {

        var user = new User
        {
            Id = 1,
            Fullname = "Tosin Omotayo"
        };

        var dto = _mapper.Map<UserDto>(user);

        return Ok(dto);
    }

    [HttpGet("document")]
    public ActionResult GetDocument()
    {

        var document = new Document
        {
            Id = 1,
            Name = "Tosin Omotayo.xls"
        };

        var dto = _mapper.Map<DocumentDto>(document);

        return Ok(dto);
    }


}
