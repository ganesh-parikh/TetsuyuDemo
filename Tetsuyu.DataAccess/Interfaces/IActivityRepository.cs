using System;
using System.Collections.Generic;
using System.Text;
using Tetsuyu.EntitiesCore.Models;

namespace Tetsuyu.DataAccess.Interfaces
{
     interface IActivityRepository
    {
        List<Activity> GetActivityList();
    }
}
