using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DM.Business;
using DM.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace DM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        ICategoriesService _ICategoriesService;
        public ValuesController(ICategoriesService iCategoriesService)
        {
            _ICategoriesService = iCategoriesService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<object> Get()
        {
            List<Categories> listCategory = _ICategoriesService.GetAll();
            return listCategory;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
