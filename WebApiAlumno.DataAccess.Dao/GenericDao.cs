using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFAlumno.Common.Contracts;
using WCFAlumno.Common.Logic;
using WCFAlumno.DataAccess.Contracts;

namespace WCFAlumno.DataAccess.Dao
{
    public class GenericDao<T> : ICrudDao<T> where T : Alumno
    {
        public T Create(T entity)
        {
            try
            {
                using (var context = new AlumnoContext())
                {
                    context.Alumno.Add(entity);
                    context.SaveChanges();

                    return ReadById(entity.Id);

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(T entity)
        {
            try
            {
                using (var context = new AlumnoContext())
                {

                    context.Alumno.Remove(entity);

                    context.SaveChanges();
                }
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
                using (var context = new AlumnoContext())
                {
                    var student = context.Alumno
                    .Where(alumno => alumno.Id == id)
                    .FirstOrDefault();

                    context.Alumno.Remove(student);

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<T> ReadAll()
        {
            try
            {
                using (var context = new AlumnoContext())
                {
                    var alumno = context.Alumno
                     .ToList<Alumno>();

                    return (List<T>)Convert.ChangeType(alumno, typeof(List<T>));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T ReadById(int id)
        {
            try
            {
                using (var context = new AlumnoContext())
                {
                    var alumno = context.Alumno
                     .Where(item => item.Id == id)
                     .FirstOrDefault();

                    return (T)Convert.ChangeType(alumno, typeof(T));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T Update(T entity)
        {
            try { 
                using (var context = new AlumnoContext())
                {
                    var studentUpdate = context.Alumno
                            .Where(alumno => alumno.Id == entity.Id)
                                .FirstOrDefault();
                    studentUpdate = entity;
                    context.SaveChanges();
                    return ReadById(entity.Id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
