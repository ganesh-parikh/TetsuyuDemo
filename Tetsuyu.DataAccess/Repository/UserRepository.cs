using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tetsuyu.DataAccess.Interfaces;
using Tetsuyu.EntitiesCore.Models;

namespace Tetsuyu.DataAccess.Repository
{
    public class UserRepository : GenericRepository<Users>, IUserRepository
    {
        public UserRepository(CoreDbContext context):base(context)
        {

        }
        public List<Users> GetUsers()
        {
            return base.Context.Users.ToList();
        }
    }
}
