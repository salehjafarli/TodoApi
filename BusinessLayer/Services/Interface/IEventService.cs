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
        Task<EventDto> GetById(int id);
        Task<List<EventDto>> GetAll();
        Task<bool> Create(EventDto evn);
        Task<bool> Update(EventDto evn);
        Task<bool> Delete(int id);
    }
}
