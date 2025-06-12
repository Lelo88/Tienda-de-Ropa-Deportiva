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
    public partial class Administrador: Form
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
            //SELECCIONA AL EMPLEADO QUE ESTA EN LA LISTA DE EMPLEADOS YA SEA
            //PARA MODIFICAR SUS DATOS O ELIMINARLO

        }

        private void btn_AgregarEmpleado_Click(object sender, EventArgs e)
        {
            //AGREGA UN NUEVO EMPLEADO EN LA LISTA DE EMPLEADOS
          
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
            //LISTA TODOS LOS EMPLEADOS CARGADOS PREVIAMENTE EN EL SISTEMA DE BBDD

        }
    }
}
