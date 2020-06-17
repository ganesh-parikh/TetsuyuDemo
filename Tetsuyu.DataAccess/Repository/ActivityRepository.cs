using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tetsuyu.DataAccess.Interfaces;
using Tetsuyu.EntitiesCore.Models;

namespace Tetsuyu.DataAccess.Repository
{
    public class ActivityRepository : GenericRepository<Activity>, IActivityRepository
    {
        public ActivityRepository(CoreDbContext context): base(context)
        {

        }
        public List<Activity> GetActivityList()
        {
            //return base.Context.Activity.ToList();
            return new List<Activity>
            {
                new Activity
                {
                    ActivityDetail ="asd",
                    ActivityId=1,
                    IsDeleted = false,
                    ProblemListIdFk = 1,

                }
            };
        }
    }
}
