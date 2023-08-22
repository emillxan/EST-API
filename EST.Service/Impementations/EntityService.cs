using EST.DAL.Interfaces;
using EST.Domain.Entities;
using EST.Domain.Response;
using EST.Domain.ViewModel.Enitity;
using EST.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EST.Service.Impementations
{
    public class EntityService : IEntityService
    {
        //For work replace all "Entity" on your entity name

        private readonly IBaseRepository<Entity> _entityRepository;

        public EntityService(IBaseRepository<Entity> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public Task<IBaseResponse<Entity>> Create(EntityCreateVM entity)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<bool>> DeleteCar(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<Entity>> Edit(long id, EntityVM model)
        {
            throw new NotImplementedException();
        }

        public IBaseResponse<List<Entity>> GetEntities()
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<EntityVM>> GetEntity(long id)
        {
            throw new NotImplementedException();
        }
    }
}
