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
    public class FremeauController : ApiController
    {
        protected virtual List<FremeauModel> Fremeau { get; set; }

        public FremeauController() : base()
        {
            this.CreateFremeauList();
        }

        private void CreateFremeauList ()
        {
            this.Fremeau = new List<FremeauModel>
            {
                new FremeauModel {
                    id = 1,
                    Name = "Hello World"
                }
            };
        }
        
        public virtual IEnumerable<FremeauModel> Get()
        {
            return this.Fremeau.AsEnumerable();
        }

        public async Task<IEnumerable<FremeauModel>> GetAsync()
        {
            return await Task.FromResult(Get());
        }

        public virtual IHttpActionResult Get(int id)
        {
            var fremeau = this.Fremeau.Where(w => w.id == id).FirstOrDefault();
            if (fremeau == null)
                return NotFound();

            return Ok(fremeau);
        }


        public virtual async Task<IHttpActionResult> GetAsync(int id)
        {
            return await Task.FromResult(Get(id));
        }
    }
}
