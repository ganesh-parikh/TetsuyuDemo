using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tetsuyu.WebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tetsuyu.EntitiesCore.Models;
using Tetsuyu.DataAccess.Repository;
using Tetsuyu.WebAPI.Common;
using System.Net;
using System.Net.Http;

namespace Tetsuyu.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UserController : BaseController<Users>
    {
        public UserController() : base(new GenericRepository<Users>(new CoreDbContext()))
        {

        }

        [HttpGet]
        [Route("GetAllUsersData")]
        public IActionResult GetAllUsersData()
        {
            var repo = new UserRepository(base.Context);
            return Ok(repo.GetUsers());
        }
    
    }
}
