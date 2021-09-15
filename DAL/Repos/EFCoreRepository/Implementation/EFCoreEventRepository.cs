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
        public bool CreateAsync(Event evn)
        {
            try
            {
                var x = dBContext.Events.Add(evn).Entity;
                dBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public bool DeleteAsync(int id)
        {
            try
            {
                Event e = dBContext.Events.FirstOrDefault(x => x.Id == id);
                e.isDeleted = true;
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
            return Task.FromResult(dBContext.Events.Where(x => x.isDeleted == false).ToList());
        }

        public Task<Event> GetByIdAsync(int id)
        {
            return Task.FromResult(dBContext.Events.FirstOrDefault(x => x.Id == id && x.isDeleted == false));
        }

        public bool UpdateAsync(Event evn)
        {
            try
            {
                Event e = dBContext.Events.FirstOrDefault(x => x.Id == evn.Id);
                dBContext.Entry(e).CurrentValues.SetValues(evn);
                dBContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            

            
        }
    }
}
