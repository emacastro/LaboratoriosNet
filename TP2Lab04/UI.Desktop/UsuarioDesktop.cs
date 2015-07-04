using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public Usuario UsuarioActual { get; set; }
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public UsuarioDesktop(int id, ModoForm modo):this()
        {
            switch (modo)
            {
                case ModoForm.Baja:
                    Modo = ModoForm.Baja;
                    break;
                case ModoForm.Consulta:
                    Modo = ModoForm.Consulta;
                    break;
                case ModoForm.Modificacion:
                    Modo = ModoForm.Modificacion;
                    break;
            }
            UsuarioLogic ulogic = new UsuarioLogic();
            UsuarioActual = ulogic.GetOne(id);
            MapearDeDatos();
        }

        public override void MapearDeDatos() 
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;
            switch (Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }
        }
        public override void MapearADatos() 
        {
            if (Modo == ModoForm.Alta)
            {
                UsuarioActual = new Usuario();
                UsuarioActual.State = BusinessEntity.States.New;
            }
            else if (Modo == ModoForm.Modificacion)
            {
                UsuarioActual.ID = int.Parse(this.txtID.Text);
                UsuarioActual.State = BusinessEntity.States.Modified;
            }
            UsuarioActual.Habilitado = this.chkHabilitado.Checked;
            UsuarioActual.Nombre = this.txtNombre.Text;
            UsuarioActual.Apellido = this.txtApellido.Text;
            UsuarioActual.Email = this.txtEmail.Text;
            UsuarioActual.NombreUsuario = this.txtUsuario.Text;
            UsuarioActual.Clave = this.txtClave.Text;
        }
        public override void GuardarCambios() { }
        public override bool Validar() { return false; }
    }
}
