using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FremeauAPI.Models;
using System.Threading.Tasks;

namespace FremeauAPI.Controllers
{
    public class FremeauDatabaseController : FremeauConsoleController
    {
        public override bool Post(FremeauModel fremeau)
        {
            return base.Post(fremeau); // currently throws exception. Will eventually write to DB
        }
    }
}