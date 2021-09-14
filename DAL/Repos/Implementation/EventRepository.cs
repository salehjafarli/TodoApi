using DAL.Entity;
using DAL.Repos.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Implementation
{
    public class EventRepository : BaseRepository, IEventRepository
    {

        public EventRepository(Context context) : base(context)
        {

        }
        public Task<Event> CreateEventAsync(Event evn)
        {
            return Task.FromResult(context.Events.Add(evn));
        }

        public Task<bool> DeleteEventAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Event> GetbyIdAsync(int id)
        {
            
            return Task.FromResult(context.Events.FirstOrDefault(x => x.Id == id));
            
            
        }

        public Task<List<Event>> GetListAsync()
        {
            return Task.FromResult(context.Events.ToList());
        }

        public Task<Event> UpdateEventAsync(Event evn)
        {
            return Task.FromResult(new Event());
        }
    }
}
