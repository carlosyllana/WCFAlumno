using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFAlumno.Common.Logic
{
    public class AlumnoContext : DbContext
    {
        public AlumnoContext() : base("AlumnoContext")
        {

            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Alumno> Alumno { get; set; }

    }
}
