using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFAlumno.Common.Contracts;

namespace WCFAlumno.DataAccess.Contracts
{
    public interface IDeleteDao<T> where T: VuelingObject
    {
        void Delete (T entity);
        void DeleteById (int id);

    }
}
