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
        public bool Create(EventDto evn)
        {
            try
            {
                var mapper = new AutoMapper<EventDto, Event>();
                Event ev = mapper.Map(evn);
                return repo.EventRepository.CreateAsync(ev);
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool Delete(int id)
        {
            return repo.EventRepository.DeleteAsync(id);
        }

        public List<EventDto> GetAll()
        {
            var list = repo.EventRepository.GetAllAsync().Result;
            var mapper = new AutoMapper<Event, EventDto>();
            List<EventDto> res = list.Select(x => mapper.Map(x)).ToList();
            return res;

        }

        public EventDto GetById(int id)
        {
            Event e = repo.EventRepository.GetByIdAsync(id).Result;
            var mapper = new AutoMapper<Event, EventDto>();
            return mapper.Map(e);
        }

        public bool Update(EventDto evn)
        {
            try
            {
                var mapper = new AutoMapper<EventDto, Event>();
                Event ev = mapper.Map(evn);
                return repo.EventRepository.UpdateAsync(ev);
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
