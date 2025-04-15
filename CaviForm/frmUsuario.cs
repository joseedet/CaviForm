using DAL;
using Microsoft.EntityFrameworkCore;
using Models;
using static Validaciones.IValidacion<Models.ViewModels.ViewModelUsuario>;
using MaterialSkin;
using MaterialSkin.Controls;
using EjemploLogin;
using Models.ViewModels;

namespace CaviForm
{
    public partial class frmUsuario : MaterialForm
    {
        private List<Rol> roles = new List<Rol>();
        private ViewModelUsuario user = new ViewModelUsuario();
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
            MaterialUI.loadMaterial(this);
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
                //repetirContra = user.RepetirContra;
                rolUsuario = user.RolId;
                fechaModificacion = user.FechaModificacionContra;
                correoUsuario = user.Correo;

                var func = Validator.Validate(user, Validaciones.ValidacionUsuario.validations) ?
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

        public static void Error ( ) => MessageBox.Show("Error!!!, uno o más valores no han sido apropiadamente cumplimentados.");


        private void btnCancelar_Click (object sender, EventArgs e) => Close();

        
      
    }
    //TODO:Validaciones individuales de cada campo
}
