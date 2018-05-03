using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFAlumno.Business.Contracts;
using WCFAlumno.Common.Logic;
using WCFAlumno.DataAccess.Contracts;

namespace WCFAlumno.Business.Logic
{


    public class AlumnoBl : ICrudBl
    {
        private readonly ICrudDao<Alumno> iDao;
        public AlumnoBl(ICrudDao<Alumno> iDao)
        {
            this.iDao = iDao;
        }


        public Alumno Create(Alumno entity)
        {
            try
            {
                return iDao.Create(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(Alumno entity)
        {
            try
            {
                iDao.Delete(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteById(int id)
        {
            try
            {
                 iDao.DeleteById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Alumno> ReadAll()
        {
            try
            {
                return iDao.ReadAll();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Alumno ReadById(int id)
        {
            try
            {
                return iDao.ReadById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Alumno Update(Alumno entity)
        {
            try
            {
                return iDao.Update(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
