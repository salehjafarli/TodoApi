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
        EventDto GetAll();
        EventDto Create(EventDto evn);
        EventDto Update(EventDto evn);
        EventDto Delete(EventDto evn);
    }
}
