using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFAlumno.Common.Contracts;

namespace WCFAlumno.DataAccess.Contracts
{
    public interface ICrudDao<T> : ICreateDao<T>, IReadDao<T>,IUpdateDao<T>, IDeleteDao<T> where T:VuelingObject
    {
    }
}
