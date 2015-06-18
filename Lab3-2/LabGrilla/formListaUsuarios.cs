using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabGrilla
{
    public partial class formListaUsuarios : Form
    {
        private Negocio.Usuarios _usuarios;
        public Negocio.Usuarios oUsuarios
        {
            get { return _usuarios; }
            set { _usuarios = value; }
        }

        public formListaUsuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.GenerarColumnas();
            this.oUsuarios = new Negocio.Usuarios();
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.RecargarGrilla();
        }
        private void RecargarGrilla()
        {
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
        }

        private void GuardarCambios()
        {
            this.oUsuarios.GuardarCambios((DataTable)this.dgvUsuarios.DataSource);
        }
        private void GenerarColumnas()
        {
            DataGridViewTextBoxColumn colNroDoc = new DataGridViewTextBoxColumn();
            colNroDoc.Name = "nro_doc";
            colNroDoc.HeaderText = "Nro. Documento";
            colNroDoc.DataPropertyName = "nro_doc";
            colNroDoc.DisplayIndex = 0;

            this.dgvUsuarios.Columns.Add(colNroDoc);

            DataGridViewComboBoxColumn colTipoDoc = new DataGridViewComboBoxColumn();
            colTipoDoc.Name = "tipo_doc";
            colTipoDoc.HeaderText = "Tipo Documento";
            colTipoDoc.DataPropertyName = "tipo_doc";
            colTipoDoc.DisplayIndex = 0;

            colTipoDoc.DataSource = this.getTiposDocumento();
            colTipoDoc.ValueMember = "cod_tipo_doc";
            colTipoDoc.DisplayMember = "desc_tipo_doc";

            this.dgvUsuarios.Columns.Add(colTipoDoc);

            DataGridViewTextBoxColumn colTel = new DataGridViewTextBoxColumn();
            colTel.Name = "telefono";
            colTel.HeaderText = "Telefono";
            colTel.DataPropertyName = "telefono";

            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "email";
            colEmail.HeaderText = "Email";
            colEmail.DataPropertyName = "email";

            DataGridViewTextBoxColumn colCel = new DataGridViewTextBoxColumn();
            colCel.Name = "celular";
            colCel.HeaderText = "Celular";
            colCel.DataPropertyName = "celular";

            DataGridViewTextBoxColumn colUsuario = new DataGridViewTextBoxColumn();
            colUsuario.Name = "usuario";
            colUsuario.HeaderText = "Usuario";
            colUsuario.DataPropertyName = "usuario";

            DataGridViewTextBoxColumn colClave = new DataGridViewTextBoxColumn();
            colClave.Name = "clave";
            colClave.HeaderText = "Clave";
            colClave.DataPropertyName = "clave";

            colEmail.Width = 250;
            colNroDoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colClave.Visible = false;

            this.dgvUsuarios.Columns["direccion"].Width = 250;
            this.dgvUsuarios.Columns["apellido"].DefaultCellStyle.Font =
            new Font(this.dgvUsuarios.DefaultCellStyle.Font, FontStyle.Bold);
            this.dgvUsuarios.Columns["nombre"].DefaultCellStyle.Font =
            new Font(this.dgvUsuarios.DefaultCellStyle.Font, FontStyle.Bold);
            this.dgvUsuarios.Columns["fecha_nac"].DefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleRight;


            this.dgvUsuarios.Columns.Add(colTel);
            this.dgvUsuarios.Columns.Add(colEmail);
            this.dgvUsuarios.Columns.Add(colUsuario);
            this.dgvUsuarios.Columns.Add(colClave);

        }
        private DataTable getTiposDocumento()
        {
            DataTable dtTiposDoc = new DataTable();

            dtTiposDoc.Columns.Add("cod_tipo_doc", typeof(int));
            dtTiposDoc.Columns.Add("desc_tipo_doc", typeof(string));

            dtTiposDoc.Rows.Add(new object[] { 1, "DNI" });
            dtTiposDoc.Rows.Add(new object[] { 2, "Cédula" });
            dtTiposDoc.Rows.Add(new object[] { 3, "Pasaporte" });
            dtTiposDoc.Rows.Add(new object[] { 4, "Libreta Cívica" });
            dtTiposDoc.Rows.Add(new object[] { 5, "Libreta Enrolamiento" });

            return dtTiposDoc;
        }

    }
}
