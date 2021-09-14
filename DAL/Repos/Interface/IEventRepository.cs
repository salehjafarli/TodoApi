using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Interface
{
    public interface IEventRepository
    {
        Task<Event> GetbyIdAsync(int id);
        Task<List<Event>> GetListAsync();
        Task<Event> CreateEventAsync(Event evn);
        Task<Event> UpdateEventAsync(Event evn);
        Task<bool> DeleteEventAsync(int id);
    }
}
