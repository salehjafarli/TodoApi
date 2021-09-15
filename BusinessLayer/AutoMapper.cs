using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AutoMapper<T1,T2>
    {
        public T2 Map(T1 t)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<T1, T2>(); });
            IMapper mapper = config.CreateMapper();
            T2 res = mapper.Map<T1, T2>(t);
            return res;
        }

    }
}
