using DAL.Interfaces;

namespace DAL
{
    public class Departamento : IBaseRepositorio<Models.Departamento>
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

        public static Models.Departamento PorId (int id, string NonbreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static Task<List<Models.Departamento>> TodosLosRegistros (string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }
    }
}
