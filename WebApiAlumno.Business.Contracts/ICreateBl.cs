﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFAlumno.Common.Logic;

namespace WCFAlumno.Business.Contracts
{
    public interface ICreateBl
    {
        Alumno Create(Alumno alumno);

    }
}
