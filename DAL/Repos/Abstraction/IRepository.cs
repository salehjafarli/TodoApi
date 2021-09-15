using DAL.Repos.Abstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Abstraction
{
    public interface IRepository
    {
        public IEventRepository EventRepository { get; }

    }
}
