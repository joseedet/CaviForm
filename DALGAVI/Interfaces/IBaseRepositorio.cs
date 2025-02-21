using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace DAL.Interfaces
{
    interface IBaseRepositorio<T> where T:class
    {
        protected abstract static void Agregar (string Descripcion,string NombreProcedimiento );
        protected abstract static bool Actualizar (int id,string Descripcion,string NombreProcedimiento );
        protected abstract static bool Eliminar (int id,string NonbreProcedimiento);
        protected abstract static T PorId (int id,string NonbreProcedimiento);
        //protected abstract static List<object> Todos (string NonbreProcedimiento);
        protected abstract static Task<List<T>> TodosLosRegistros (string NombreProcedimiento);



    }
}
