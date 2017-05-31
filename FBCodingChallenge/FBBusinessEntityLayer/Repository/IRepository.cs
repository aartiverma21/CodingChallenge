using FBDAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBMiddleTier.Repository
{
    public interface IRepository<T> where T:Entity
    {
        IEnumerable<T> List { get; }
        void AddUser(T entity);
    }
}
