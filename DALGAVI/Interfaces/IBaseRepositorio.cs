namespace DAL.Interfaces
{
    interface IBaseRepositorio<T> where T:class
    {
        protected abstract static void Agregar (string Descripcion,bool Activo,string NombreProcedimiento );
        protected abstract static bool Actualizar (int id,string Descripcion,bool Activo,string NombreProcedimiento );
        protected abstract static bool Eliminar (int id,string NonbreProcedimiento);
        protected abstract static T PorId (int id,bool Activo, string NombreProcedimiento);
        //protected abstract static List<object> Todos (string NonbreProcedimiento);
        protected abstract static List<T> TodosLosRegistros (string NombreProcedimiento);



    }
}
