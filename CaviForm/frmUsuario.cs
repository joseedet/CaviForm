using Azure.Core;
using DAL;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;
using Models;
using static Validaciones.IValidacion<Models.Usuario>;

namespace CaviForm
{
    public partial class frmUsuario : Form
    {
        private List<Rol> roles = new List<Rol>();
        private Usuario user = new Usuario();
        private static string? usuarioId;
        private static string? nombreUsuario;
        private static string? apellidoUsuario;
        private static string? contrasnyaUsuario;
        private static string? repetirContra;
        private static int ? rolUsuario;
        private static DateTime fechaModificacion;
        private static string ? correoUsuario;

        public frmUsuario ( )
        {
            InitializeComponent();
        }

        private void frmUsuario_Load (object sender, EventArgs e)
        {


            roles = DALRol.TodosLosRegistros("ListarTodosRol");


            cboRol.DataSource = null;
            cboRol.DataSource = roles;
            cboRol.ValueMember = "RolId";
            cboRol.DisplayMember = "Descripcion";

        }

        private void btnNuevo_MouseEnter (object sender, EventArgs e)
        {
            toolTipUsuario.SetToolTip(btnNuevo, "Nuevo");
        }

        private void btnCerrar_MouseEnter (object sender, EventArgs e)
        {
            toolTipUsuario.SetToolTip(btnCerrar, "Cerrar");
        }

        private void btnDeshacer_MouseEnter (object sender, EventArgs e)
        {
            toolTipUsuario.SetToolTip(btnDeshacer, "Deshacer");
        }

        private void btnGuardar_MouseEnter (object sender, EventArgs e)
        {
            toolTipUsuario.SetToolTip(btnGuardar, "Guardar");
        }

        private void btnEditar_MouseEnter (object sender, EventArgs e)
        {
            toolTipUsuario.SetToolTip(btnEditar, "Editar");
        }

        private void btnGuardar_Click (object sender, EventArgs e)
        {
            try
            {
                //miUsuario = Usuario.Descripcion;
                usuarioId = user.UsuarioId;
                nombreUsuario = user.Nombre;
                apellidoUsuario = user.Apellidos;
                contrasnyaUsuario = user.Contrasenya;
                repetirContra = user.RepetirContra;
                rolUsuario = user.RolId;
                fechaModificacion = user.FechaModificacionContra;
                correoUsuario = user.Correo;

                var func = Validator.Validate(user, Validaciones.ValiddacionUsuario.validations) ?
                (Action)Success :
                (Action)Error;

                func();

            }
            catch(DbUpdateException ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }
        public static void Success ( )
        {
            Ejecutar();
        }

        /// <summary>
        /// Ejecutamos procediento de inssertar registro.
        /// </summary>
        private static void Ejecutar ( ) => DALUsuario.Agregar(usuarioId.ToUpper(), nombreUsuario.ToUpper(), apellidoUsuario.ToUpper(), 
                                                                contrasnyaUsuario, fechaModificacion, (int)rolUsuario, correoUsuario, 
                                                                "InsertUsuario");

        public static void Error ( ) => MessageBox.Show("error");


        private void btnCancelar_Click (object sender, EventArgs e) => Close();

        
      
    }
}
