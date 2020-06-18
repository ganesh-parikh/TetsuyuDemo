using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tetsuyu.EntitiesCore.Models;
using Tetsuyu.DataAccess.Repository;

namespace Tetsuyu.WebAPI.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
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
