using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Models;

namespace DALGAVI
{
    public class DalClientes : IBaseRepositorio
    {
        public static bool Actualizar (int id, string Descripcion, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static void Agregar (string Descripcion, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static bool Eliminar (int id, string NonbreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static Cliente PorId (int id, string NonbreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static List<Cliente> Todos (string NonbreProcedimiento)
        {
            throw new NotImplementedException();
        }

        static object IBaseRepositorio.PorId (int id, string NonbreProcedimiento)
        {
            return PorId(id, NonbreProcedimiento);
        }

        static List<object> IBaseRepositorio.Todos (string NonbreProcedimiento)
        {
            throw new NotImplementedException();
        }
    }
}
