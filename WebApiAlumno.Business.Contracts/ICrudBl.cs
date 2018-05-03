using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFAlumno.Business.Contracts
{
    public interface ICrudBl: ICreateBl, IReadBl, IUpdateBl, IDeleteBl
    {
    }
}
