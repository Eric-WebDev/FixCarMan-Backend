﻿using Application.Profiles;
using Identity.Application.Adverts;
using Identity.Application.Profiles;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Identity.API.Controllers
{
    public class ProfilesController : BaseController
    {
        
        [HttpGet("{username}")]
        [Authorize]
        public async Task<ActionResult<Profile>> Get(string username)
        {
            return await Mediator.Send(new Details.Query { Username = username });
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult<Unit>> Edit(Edit.Command command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet("{username}/adverts")]
        [Authorize]
        public async Task<ActionResult<List<UserAdDto>>> GetUserAdverts(string username, string predicate)
        {
            return await Mediator.Send(new ListAds.Query { Username = username, Predicate = predicate });

        }
    }
}
