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
    public class FremeauConsoleController : FremeauController
    {
        
        public virtual bool Post (FremeauModel fremeau)
        {
            // will write to console on POST
            throw new NotImplementedException();
        }
    }
}