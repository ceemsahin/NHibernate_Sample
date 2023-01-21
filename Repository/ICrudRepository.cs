using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICrudRepository<T>
    {

        void Insert(T entities);
        void Update(T entities);
        void Delete(T entities);
        T GetById(int id);
        IList<T> GetAll();

    }
}
