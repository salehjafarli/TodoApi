using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Abstraction.Interfaces
{
    public interface IEventRepository
    {
        Task<Event> GetByIdAsync(int id);
        Task<List<Event>> GetAllAsync();
        bool  CreateAsync(Event evn);
        bool UpdateAsync(Event evn);
        bool DeleteAsync(int id);




    }
}
