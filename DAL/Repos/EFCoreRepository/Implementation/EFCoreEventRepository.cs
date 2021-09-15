using DAL.Entities;
using DAL.Repos.Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.EFCoreRepository.Implementation
{
    public class EFCoreEventRepository :EFCoreBaseRepository, IEventRepository
    {
        public EFCoreEventRepository(TodoDBContext dBContext):base(dBContext)
        {

        }
        public Task<Event> CreateAsync(Event evn)
        {

            var x = dBContext.Events.Add(evn).Entity;
            dBContext.SaveChangesAsync();
            return Task.FromResult(x);
        }

        public bool DeleteAsync(Event evn)
        {
            try
            {
                evn.isDeleted = true;
                var x = UpdateAsync(evn);
                dBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
            
        }

        public Task<List<Event>> GetAllAsync()
        {
            return Task.FromResult(dBContext.Events.ToList());
        }

        public Task<Event> GetByIdAsync(int id)
        {
            return Task.FromResult(dBContext.Events.FirstOrDefault());
        }

        public Task<Event> UpdateAsync(Event evn)
        {
            Event e = dBContext.Events.FirstOrDefault(x => x.Id == evn.Id);
            e = evn;
            dBContext.SaveChangesAsync();
            return Task.FromResult(e);

            
        }
    }
}
