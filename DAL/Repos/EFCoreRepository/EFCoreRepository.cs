using DAL.Repos.Abstraction;
using DAL.Repos.Abstraction.Interfaces;
using DAL.Repos.EFCoreRepository.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.EFCoreRepository
{
    public class EFCoreRepository : IRepository
    {
        public readonly TodoDBContext dBContext;

        public EFCoreRepository(TodoDBContext dBContext)
        {
            this.dBContext = dBContext;
            
             
        }

        public IEventRepository EventRepository => new EFCoreEventRepository(dBContext);
    }
}
