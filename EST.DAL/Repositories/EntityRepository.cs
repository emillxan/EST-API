using EST.DAL.Interfaces;
using EST.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EST.DAL.Repositories
{
    //Entity - Entyty name in DB
    //For work replace all "Entity" on your entity name
    public class EntityRepository : IBaseRepository<Entity>
    {
        private readonly ApplicationDbContext _db;

        public EntityRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> Create(Entity entity)
        {
            await _db.Entity.AddAsync(entity);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(Entity entity)
        {
            _db.Entity.Remove(entity);
            await _db.SaveChangesAsync();
            return true;
        }

        public IQueryable<Entity> GetAll()
        {
            return _db.Entity;
        }

        public async Task<Entity> Update(Entity entity)
        {
            _db.Entity.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }
    }
}
