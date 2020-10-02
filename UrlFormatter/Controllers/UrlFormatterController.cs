using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using UrlFormatter.Requests;

namespace UrlFormatter.Controllers
{
    [ApiController]
    [Route("api/v1.0/url")]
    public class UrlFormatterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UrlFormatterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string originalUrl)
        {
            var result = await _mediator.Send(new UrlFormatterRequest
            {
                OriginalUrl = originalUrl
            });
            return Ok(result);
        }
    }
}
