using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Parking.Core.Dtos;
using Parking.Core.Interfaces;
using Parking.Core.ProjectAggregate.Queries.UserQueries;

namespace Parking.API.Controllers;
[ApiController]
[Route("api/user")]
public class UserController:ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public UserController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var users = await _mediator.Send(new UserGetQuery());
        var usersDto = _mapper.Map<List<UserDto>>(users);
        return Ok(usersDto);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(long id)
    {
        var user = await _mediator.Send(new UserGetByIdQuery(id));
        var userDto = _mapper.Map<UserDto>(user);
        return Ok(userDto);
    }
}