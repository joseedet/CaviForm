using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    class DataContext:DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options)
       {
            

       }
        public DbSet<Almacen> almacenes { get; set; }
        //public DbSet<Cliente> clientes { get; set; }
        public DbSet<Departamento> departamentos { get; set; }
        public DbSet<IVA> ivas { get; set; }
        public DbSet<Medida> medidas { get; set; }
       
        public DbSet<TipoDocumento> tipoDocumentos { get; set; }



    }
}
