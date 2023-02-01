using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Diet.DAL.Entities;
using Diet.Model;

namespace Diet.DAL.GenericRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Base
    {
        private readonly DietAppContext _db = null;
        public Repository(DietAppContext db)
        {
            _db = db;
        }
        public void Create(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
            _db.SaveChanges();
        }

        public void Delete(int Id)
        {
            var entity = GetById(Id);
            _db.Set<TEntity>().Remove(entity);
            _db.SaveChanges();
        }

        public IQueryable<TEntity> GetAll()
        {
           return _db.Set<TEntity>().AsNoTracking();
        }

        public TEntity GetById(int Id)
        {
            return _db.Set<TEntity>().AsNoTracking().FirstOrDefault(x=> x.ID == Id);
        }

        public void Update(TEntity entity)
        {
            _db.Set<TEntity>().Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
