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
        public async Task<bool> Create(EventDto evn)
        {
            try
            {
                var mapper = new AutoMapper<EventDto, Event>();
                Event ev = mapper.Map(evn);
                return await repo.EventRepository.CreateAsync(ev);
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public async Task<bool> Delete(int id)
        {
            return await repo.EventRepository.DeleteAsync(id);
        }

        public async Task<List<EventDto>> GetAll()
        {
            var list = await repo.EventRepository.GetAllAsync();
            var mapper = new AutoMapper<Event, EventDto>();
            List<EventDto> res = list.Select(x => mapper.Map(x)).ToList();
            return res;

        }

        public async Task<EventDto> GetById(int id)
        {
            Event e =await repo.EventRepository.GetByIdAsync(id);
            var mapper = new AutoMapper<Event, EventDto>();
            return mapper.Map(e);
        }

        public async Task<bool> Update(EventDto evn)
        {
            try
            {
                var mapper = new AutoMapper<EventDto, Event>();
                Event ev = mapper.Map(evn);
                return await repo.EventRepository.UpdateAsync(ev);
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
