using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Diet.Model;

namespace Diet.DAL.GenericRepository
{
    public interface IRepository<TEntity> where TEntity : Base
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(int Id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(int Id);
    }
}
