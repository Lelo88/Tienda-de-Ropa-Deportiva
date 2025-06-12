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
    public partial class EncargadoDeDeposito: Form
    {
        public EncargadoDeDeposito()
        {
            InitializeComponent();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_SeleccionarProducto_Click(object sender, EventArgs e)
        {
            //SELECCIONA UN PRODUCTO, SOLO HACIENDO CLICK Y OBTIENE LOS DATOS DEL PRODUCTO
            //DEBE ESTAR LA TABLA PREVIAMENTE CARGADA CON PRODUCTOS
            btn_modificarProducto.Enabled = true;
            btn_eliminarProducto.Enabled = true;
        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            //AGREGA EL PRODUCTO A LA LISTA DE PRODUCTOS
            //DEBE ESTAR LA TABLA PREVIAMENTE CARGADA CON PRODUCTOS

        }

        private void btn_modificarProducto_Click(object sender, EventArgs e)
        {
            //PARA QUE UN PRODUCTO PUEDA SER MODIFICADO, PREVIAMENTE HAY QUE SELECCIONARLO
            //DEBE ESTAR LA TABLA PREVIAMENTE CARGADA CON PRODUCTOS
        }

        private void btn_eliminarProducto_Click(object sender, EventArgs e)
        {
            //PARA QUE UN PRODUCTO PUEDA SER ELIMINADO, PREVIAMENTE HAY QUE SELECCIONARLO
        }

        private void btn_ListarProductos_Click(object sender, EventArgs e)
        {
            //LISTA TODOS LOS PRODUCTOS MEDIANTE UNA SECUENCIA SQL
            txt_IdProducto.Enabled = true;
            txt_Nombre.Enabled = true;
            txt_Precio.Enabled = true;
            nud_Cantidad.Enabled = true;
            cbo_Deporte.Enabled = true;
            txt_Marca.Enabled = true;
            txt_Modelo.Enabled = true;
            btn_SeleccionarProducto.Enabled = true;
            btn_agregarProducto.Enabled = true;
        }
    }
}
