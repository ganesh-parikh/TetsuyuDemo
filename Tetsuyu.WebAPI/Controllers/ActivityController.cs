using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tetsuyu.DataAccess.Repository;
using Tetsuyu.EntitiesCore.Models;
using Tetsuyu.WebAPI.Common;

namespace Tetsuyu.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : BaseController<Activity>
    {
        public ActivityController() : base(new GenericRepository<Activity>(new CoreDbContext()))
        {
        }

        [HttpGet]
        [Route("")]
        public List<Activity> GetSecurity()
        {
            try
            {
                var repo = new ActivityRepository(base.Context);
                return repo.GetActivityList();
                //return new ApiResult(
                //        Request,
                //        HttpStatusCode.OK,
                //        repo.GetActivityList()
                //    ).ResponseMsg;

            }
            catch (Exception ex)
            {
                return new List<Activity>();
                //return new ApiResult(Request, ex).ResponseMsg;
            }
        }

    }
}