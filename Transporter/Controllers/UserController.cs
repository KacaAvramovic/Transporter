using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persistence.Entities;
using Transporter.Application.User.Query;

namespace Transporter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        IMediator _mediator;

        public UserController(IMediator mediator, ILogger<WeatherForecastController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

  
        [HttpGet]
        [Route("{id}", Name = "GetUser")]
        [ProducesDefaultResponseType(typeof(User))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(int id, [FromQuery] params string[] extends)
        {
            var extendList = new List<string>(extends);

            var user = await _mediator.Send(new GetUsersRequest(id));

            return Ok(user);
        }
    }
}
