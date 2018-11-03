using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Infra.Business
{
    public interface IRepository<T> where T : BaseEntity
    {              
       
        void Add(T obj);

        void Update(T obj);

        void Remove(int id);

        T Get(int id);

        IList<T> GetAll();
    }
}
