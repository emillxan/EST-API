using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EST.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        //Create new entity 
        Task<bool> Create(T entity);

        //Get All entities
        IQueryable<T> GetAll();

        //Delete entity 
        Task<bool> Delete(T entity);

        //Update entity 
        Task<T> Update(T entity);
    }
}
