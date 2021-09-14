using DAL;
using DAL.Entity;
using DAL.Repos.Implementation;
using DAL.Repos.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public readonly Context context;
        public TestController(Context context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult get()
        {
            //IEventRepository a = new EventRepository(context);
            //Event e = new Event {Id = 105, Name = "asd", Description = "asfasf", StartDate = DateTime.Now,EndDate = DateTime.Now.AddMinutes(20),isDeleted = false };
            //var x =  a.CreateEventAsync(e);
            //return Ok(x.Result);
        }
    }
}
