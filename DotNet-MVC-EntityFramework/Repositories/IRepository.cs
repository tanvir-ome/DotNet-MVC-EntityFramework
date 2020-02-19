using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_MVC_EntityFramework.Repositories
{
    public interface IRepository<TEntity> where TEntity:class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
