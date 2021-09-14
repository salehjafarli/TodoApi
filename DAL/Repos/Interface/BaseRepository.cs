using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Interface
{
    public abstract class BaseRepository
    {
        public readonly Context context;
        public BaseRepository(Context context)
        {
            this.context = context;
        }
    }
}
