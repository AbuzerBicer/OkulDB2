using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<TEntity> where TEntity:class,IEntity,new()
    {
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
        public TEntity Get(byte entityID);
        List<TEntity> GetAll();
    }
}
