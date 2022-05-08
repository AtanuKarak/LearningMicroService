using LearningMicroService.Common;
using LearningMicroService.Service;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LearningMicroService.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Constructor of People Controller
        /// </summary>
        /// <param name="mediator"></param>
        public PeopleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Action to get list of people
        /// </summary>
        /// <returns>List of people</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        
        public async Task<ActionResult<List<Person>>> Get()
        {
            return await _mediator.Send(new GetPeopleQuery());
        }
    }
}
