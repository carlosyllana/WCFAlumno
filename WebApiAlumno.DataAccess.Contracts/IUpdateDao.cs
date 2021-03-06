﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFAlumno.Common.Contracts;

namespace WCFAlumno.DataAccess.Contracts
{
    public interface IUpdateDao<T> where T: VuelingObject
    {
        T Update (T entity);
    }
}
