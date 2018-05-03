using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFAlumno.Business.Contracts;
using WCFAlumno.Common.Logic;

namespace WCFAlumno.Bussines.FacadeWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AlumnoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AlumnoService.svc o AlumnoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AlumnoService : IAlumnoService
    {
        private readonly ICrudBl iAlumnoBl;

        public AlumnoService(ICrudBl alumnoBl)
        {
            this.iAlumnoBl = alumnoBl;
        }

        public Alumno CrearAlumno(Alumno alumno)
        {
            try
            {
                return iAlumnoBl.Create(alumno);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(Alumno alumno)
        {
            try
            {
                 iAlumnoBl.Delete(alumno);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Alumno> ReadAlumnos()
        {
            try
            {
                return iAlumnoBl.ReadAll();
             }
            catch (Exception)
            {

                throw;
            }
}

        public Alumno Update(Alumno alumno)
        {
            try
            {
                return iAlumnoBl.Update(alumno);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
