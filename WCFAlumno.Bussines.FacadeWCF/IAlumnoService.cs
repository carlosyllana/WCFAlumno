using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFAlumno.Common.Logic;

namespace WCFAlumno.Bussines.FacadeWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAlumnoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAlumnoService
    {
        [OperationContract]
        Alumno CrearAlumno(Alumno alumno);
        [OperationContract]
        List<Alumno> ReadAlumnos();
        [OperationContract]
        Alumno Update(Alumno alumno);
       [OperationContract]
        void  Delete(Alumno alumno);
    }
}
