﻿using Identity.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Identity.Application.Profiles
{
    public class Details
    {
        public class Query : IRequest<Profile>
        {
            public string Username { get; set; }
        }

        public class Handler : IRequestHandler<Query, Profile>
        {
            private readonly IProfileReader _profileReader;
            public Handler(IProfileReader profileReader)
            {
                _profileReader = profileReader;
            }

            public async Task<Profile> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _profileReader.ReadProfile(request.Username);
            }
        }
    }
}
