﻿using System;
using System.Security.Claims;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class BaseController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator =>
            _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        //internal Int32 UserId => !User.Identity.IsAuthenticated
         //   ? Int32.Empty
        //    : Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
    }
}