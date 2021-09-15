using BusinessLayer.DataTransferObjects;
using BusinessLayer.Services.Interface;
using DAL.Entities;
using DAL.Repos.Abstraction;
using DAL.Repos.Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Concrete
{
    public class  EventService : IEventService
    {
        public readonly IRepository repo;
        public EventService(IRepository repo)
        {
            this.repo = repo;
        }
        public EventDto Create(EventDto evn)
        {
            throw new NotImplementedException();
        }

        public EventDto Delete(EventDto evn)
        {
            throw new NotImplementedException();
        }

        public EventDto GetAll()
        {
            throw new NotImplementedException();
        }

        public EventDto GetById(int id)
        {
            Event e = repo.EventRepository.GetByIdAsync(id).Result;
            var mapper = new AutoMapper<Event, EventDto>();
            return mapper.Map(e);
        }

        public EventDto Update(EventDto evn)
        {
            throw new NotImplementedException();
        }
    }
}
