using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.EFCoreRepository
{
    public abstract class EFCoreBaseRepository
    {
        public readonly TodoDBContext dBContext;
        public EFCoreBaseRepository(TodoDBContext dBContext)
        {
            this.dBContext = dBContext;
        }
    }
}
