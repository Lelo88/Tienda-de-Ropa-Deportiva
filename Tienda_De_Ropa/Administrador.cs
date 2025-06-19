using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_De_Ropa
{
    public partial class Administrador : Form
    {

        public Administrador()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Seguro que desea cerrar sesion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, false);
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("Cerrando sesion...");
                this.Hide();
                Iniciar_Sesion iniciar_sesion = new Iniciar_Sesion();
                MessageBox.Show("HASTA LUEGO!!");
                iniciar_sesion.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("El sistema seguira en funcionamiento");
            }
        }

        private void btn_SeleccionarEmpleado_Click(object sender, EventArgs e)
        {

            btn_ModificarEmpleado.Enabled = true;
            btn_EliminarEmpleado.Enabled = true;
            cbo_tipoDeEmpleado.Enabled = true;
            cbo_tipoDeEmpleado.Items.Clear();
            cbo_tipoDeEmpleado.Items.Remove("");
            DataGridViewRow row = dataGridView1.CurrentRow;
            int idEmpleado = Convert.ToInt32(row.Cells["ColIdEmpleado"].Value);
            //string tipoEmpleado = row.Cells["ColTipoEmpleado"].Value.ToString();
            string descripcion = row.Cells["ColDescripcion"].Value.ToString();
            string nombre = row.Cells["ColNombre"].Value.ToString();
            string apellido = row.Cells["ColApelido"].Value.ToString();
            string dni = row.Cells["ColDni"].Value.ToString();
            string usuario = row.Cells["ColUsuario"].Value.ToString();
            string contrasena = row.Cells["ColContraseña"].Value.ToString();
            txt_idEmpleado.Text = idEmpleado.ToString();
            cbo_tipoDeEmpleado.Items.Add(descripcion);
            txt_nombre.Text = nombre;
            txt_apellido.Text = apellido;
            txt_dni.Text = dni;
            txt_usuario.Text = usuario;
            txt_contrasenia.Text = contrasena;


        }

        private void btn_AgregarEmpleado_Click(object sender, EventArgs e)
        {
            BLL.Administrador administrador = new BLL.Administrador();
            ConfigurarDataGridViewColumnasPorCodigo();
            dataGridView1.DataSource = administrador.Alta_de_empleado();
        }

        private void btn_ModificarEmpleado_Click(object sender, EventArgs e)
        {
            //MODIFICA LOS DATOS DEL EMPLEADO SELECCIONADO
        }

        private void btn_EliminarEmpleado_Click(object sender, EventArgs e)
        {
            //ELIMINAR LOS DATOS DEL EMPLEADO SELECCIONADO

        }

        private void btn_ListarEmpleados_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            btn_AgregarEmpleado.Enabled = true;
            btn_SeleccionarEmpleado.Enabled = true;
            BLL.Administrador administrador = new BLL.Administrador();
            ConfigurarDataGridViewColumnasPorCodigo();
            dataGridView1.DataSource = administrador.Listar_empleados();

        }

        private void ConfigurarDataGridViewColumnasPorCodigo()
        {

            dataGridView1.AutoGenerateColumns = false; // Desactivar auto-generación
            dataGridView1.Columns.Clear(); // Limpiar columnas existentes
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColIdEmpleado", HeaderText = "ID", DataPropertyName = "Id_empleado" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColTipoEmpleado", HeaderText = "Tipo de Empleado", DataPropertyName = "ID_TIPO_EMPLEADO" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColDescripcion", HeaderText = "Descripcion", DataPropertyName = "Descripcion" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColNombre", HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColApelido", HeaderText = "Apellido", DataPropertyName = "Apelido" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColDni", HeaderText = "DNI", DataPropertyName = "Dni" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColUsuario", HeaderText = "Usuario", DataPropertyName = "Usuario" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "ColContraseña", HeaderText = "Contraseña", DataPropertyName = "Contraseña" });
        }



    }
}
