using BusinessLayer.Services.Interface;
using DAL;
using DAL.Entities;
using DAL.Repos.Abstraction;
using DAL.Repos.Abstraction.Interfaces;
using DAL.Repos.EFCoreRepository;
using DAL.Repos.EFCoreRepository.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public readonly IEventService service;
        public TestController(IEventService service)
        {
             this.service = service;
        }
        [HttpGet]
        public IActionResult get()
        {
            //IRepository rep = new EFCoreRepository(context as TodoDBContext);
            Event e = new Event {Name = "asd", Description = "asfasf", StartDate = DateTime.Now,EndDate = DateTime.Now.AddMinutes(20),isDeleted = false };
            var x = service.GetById(1);
            return Ok(x);

        }
    }
}
