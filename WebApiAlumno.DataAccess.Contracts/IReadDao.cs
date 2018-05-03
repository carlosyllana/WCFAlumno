using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFAlumno.Common.Contracts;

namespace WCFAlumno.DataAccess.Contracts
{
    public interface IReadDao<T> where T: VuelingObject
    {
        T ReadById(int id);
        List<T> ReadAll();
    }
}
