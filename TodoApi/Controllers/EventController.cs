using BusinessLayer.DataTransferObjects;
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
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        public readonly IEventService EventService;
        public readonly ILogger<EventController> logger;
        public EventController(IEventService EventService, ILogger<EventController> logger)
        {
            this.EventService = EventService;
            this.logger = logger;
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult get(int id)
        {
            
            try
            {
                var result = EventService.GetById(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }


        }
        [HttpGet]
        public IActionResult getall()
        {
            try
            {
                var result = EventService.GetAll();
                return Ok(result);
            }
            catch (Exception e)
            {

                return BadRequest(e);
            }
        }
        [HttpPost]
        [Route("Create")]
        public HttpResponseMessage Create(EventDto ev)
        {
            try
            {
                var res = EventService.Create(ev);
                if (res==false)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
                }
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            }
            catch (Exception)
            {

                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        [Route("Update")]
        public HttpResponseMessage Update(EventDto ev)
        {
            try
            {
                var res = EventService.Update(ev);
                if (res == false)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
                }
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            }
            catch (Exception)
            {

                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        [Route("Delete")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var res = EventService.Delete(id);
                if (res == false)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);
                }
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            }
            catch (Exception)
            {

                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            }
        }

    }
}
