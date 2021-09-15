using BusinessLayer.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Interface
{
    public interface IEventService
    {
        EventDto GetById(int id);
        List<EventDto> GetAll();
        bool Create(EventDto evn);
        bool Update(EventDto evn);
        bool Delete(EventDto evn);
    }
}
