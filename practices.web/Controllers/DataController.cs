using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pracitices.Entity.Model;

namespace practices.web.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class DataController : ControllerBase
    {

        public DataController(IDataService dataService)
        {
            DataService = dataService;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return Ok();
        }

        [HttpGet("get/{id}")]
        public ActionResult Index(string id)
        {
            return Ok(DataService.GetData(id));
        }

        [HttpPost("insert")]
        public ActionResult Index([FromBody]Data model)
        {

            return Ok(DataService.Insert(model));
        }

        public IDataService DataService { get; }
    }
}