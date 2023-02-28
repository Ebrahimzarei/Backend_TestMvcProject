using Backend_TestedProject.DataLayer.Common;
using Backend_TestedProject.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend_TestedProject.Contract.Common
{
    //BaseRepository<TEntity> : IBaseRepository<TEntity>
    //    where TEntity : BaseEntity, new ()
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
       where TEntity :BaseEntity, new()
    {
        private readonly TestProject_Context dbContext;
        public BaseRepository(TestProject_Context dbContext)
        {
            this.dbContext = dbContext;
        }
        public TEntity Add(TEntity entity)
        {
            

            dbContext.Set<TEntity>().Add(entity);
            dbContext.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            TEntity entity = new TEntity
            {
                Id = id
            };
            dbContext.Remove(entity);
            dbContext.SaveChanges();
        }

        public TEntity Get(int id)
        {
           
            return dbContext.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().AsQueryable();
        }

        public TEntity Update(int id, TEntity entity)
        {
            TEntity newentity = new TEntity
            {
                Id = id
            };
            dbContext.Update(entity);
            dbContext.SaveChanges();
            return entity;

        }
    }
}
