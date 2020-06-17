using System;
using System.Collections.Generic;
using System.Text;
using Tetsuyu.EntitiesCore.Models;

namespace Tetsuyu.DataAccess.Interfaces
{
    interface IUserRepository
    {
        List<Users> GetUsers();
    }
}
