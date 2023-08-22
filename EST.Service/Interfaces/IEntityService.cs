using EST.Domain.Entities;
using EST.Domain.Response;
using EST.Domain.ViewModel.Enitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EST.Service.Interfaces
{
    public interface IEntityService
    {
        //For work replace all "Entity" on your entity name

        IBaseResponse<List<Entity>> GetEntities();

        Task<IBaseResponse<EntityVM>> GetEntity(long id);

        Task<IBaseResponse<Entity>> Create(EntityCreateVM entity);

        Task<IBaseResponse<bool>> DeleteCar(long id);

        Task<IBaseResponse<Entity>> Edit(long id, EntityVM model);
    }
}
