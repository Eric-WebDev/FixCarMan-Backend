﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle.Data.Models;
using Vehicle.Logic.Garages;

namespace Vehicle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaragesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GaragesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //geting list of garages method
        [HttpGet]
        public async Task<ActionResult<List<Garage>>> List()
        {
            return await _mediator.Send(new List.Query());
        }


    }
}
