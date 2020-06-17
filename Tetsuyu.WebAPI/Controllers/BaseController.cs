using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tetsuyu.DataAccess.Interfaces;
using Tetsuyu.EntitiesCore.Models;

namespace Tetsuyu.WebAPI.Controllers
{
    public class BaseController<T> : ControllerBase where T : class, new()
    {
        public IGenericRepository<T> repository;

        private CoreDbContext _Context;
        public BaseController(IGenericRepository<T> repository)
        {
            this.repository = repository;
            _Context = this.repository.Context;
        }

        public CoreDbContext Context { get { return _Context; } }
    }
}