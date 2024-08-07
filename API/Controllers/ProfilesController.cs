using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Profiles;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProfilesController : BaseApiController
    {
        [HttpGet("{usermane}")]

        public async Task<IActionResult> GetProfile(string usermane)
        {
            return HandleResult(await Mediator.Send(new Details.Query{Username = usermane}));
        }
    }
}