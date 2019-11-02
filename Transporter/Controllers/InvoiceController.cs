using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persistence.Entities;
using Transporter.Application.User.Query;

namespace Transporter.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly ILogger<InvoiceController> _logger;
        IMediator _mediator;

        public InvoiceController(IMediator mediator, ILogger<InvoiceController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

  
        [HttpGet]
        [Route("{id}", Name = "GetInvoice")]
        [ProducesDefaultResponseType(typeof(Invoice))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(int id, [FromQuery] params string[] extends)
        {
            var extendList = new List<string>(extends);

            var invoice = await _mediator.Send(new GetInvoicesRequest(id));

            return Ok(invoice);
        }
    }
}
