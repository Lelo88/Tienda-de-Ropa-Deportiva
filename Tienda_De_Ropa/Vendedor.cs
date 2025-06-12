using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_De_Ropa
{
    public partial class Vendedor: Form
    {
        public Vendedor()
        {
            InitializeComponent();
            

        }

        private void Vendedor_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_CancelarVenta_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Si le da que si, se cancelara toda la venta para el cliente ¿ESTA SEGURO?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, false);
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("SE HA CANCELADO LA VENTA");
                //LIMPIA LOS DATOS DE LOS TXT Y LOS CBO
                txt_IdVendedor.Clear();
                txt_IdVenta.Clear();
                txt_ApellidoCliente.Clear();
                txt_NombreCliente.Clear();
                txt_ClienteNro.Clear();
                txt_DniCliente.Clear();
                txt_Fecha.Clear();
                cbo_MetodoDePago.Items.Clear();
                txt_Total.Clear();
                cbo_Producto.Items.Clear();
                nud_Cantidad.Value = 0;
                txt_Precio.Clear();

                //ARMAR CONSULTA SQL PARA LIMPIAR LA TABLA DE VENTAS DEL CLIENTE
                //LIMPIA LOS DATOS DE LOS TXT Y LOS CBO

                //DESHABILITA EL USO DE LA INTERAZ
                txt_IdVendedor.Enabled = false;
                txt_IdVenta.Enabled = false;
                txt_ApellidoCliente.Enabled = false;
                txt_NombreCliente.Enabled = false;
                txt_ClienteNro.Enabled = false;
                txt_DniCliente.Enabled = false;
                txt_Fecha.Enabled = false;
                cbo_MetodoDePago.Enabled = false;
                txt_Total.Enabled = false;
                cbo_Producto.Enabled = false;
                nud_Cantidad.Enabled = false;
                txt_Precio.Enabled = false;
                btn_AgregarProductoALista.Enabled = false;
                btn_ConfirmarVenta.Enabled = false;
                btn_CancelarVenta.Enabled = false;
                btn_EliminarProductoDeLista.Enabled = false;
                //ARMAR CONSULTA SQL PARA LIMPIAR LA TABLA DE VENTAS DEL CLIENTE
                //DESHABILITA EL USO DE LA INTERAZ
            }
            else
            {
                MessageBox.Show("El sistema seguira en funcionamiento");
            }

            

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_Fecha_TextChanged(object sender, EventArgs e)
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

        private void btn_GenerarVenta_Click(object sender, EventArgs e)
        {
            txt_IdVendedor.Enabled = true;
            txt_IdVenta.Enabled = true;
            txt_ApellidoCliente.Enabled = true;
            txt_NombreCliente.Enabled = true;
            txt_ClienteNro.Enabled = true;
            txt_DniCliente.Enabled = true;
            txt_Fecha.Enabled = true;
            cbo_MetodoDePago.Enabled = true;
            txt_Total.Enabled = true;
            cbo_Producto.Enabled = true;
            nud_Cantidad.Enabled = true;
            txt_Precio.Enabled = true;
            btn_AgregarProductoALista.Enabled = true;
            btn_ConfirmarVenta.Enabled = true;
            btn_CancelarVenta.Enabled = true;
            btn_EliminarProductoDeLista.Enabled = true;
            txt_Fecha.Text = DateTime.Now.ToString("dd MM yyyy");
        }

        private void btn_EliminarProductoDeLista_Click(object sender, EventArgs e)
        {
            //HACER CCONSULTA SQL PARA ELIMINAR PRODUCTO CARGADO EN LA LISTA
        }

        private void btn_ConfirmarVenta_Click(object sender, EventArgs e)
        {
            //EN SQL CARGAR TODAS LAS VENTAS DE UN CLIENTE
        }

        private void btn_AgregarProductoALista_Click(object sender, EventArgs e)
        {
            //LIMPIAR TODOS LOS DATOS EXCEPTO LOS DEL VENDEDOR Y DEL CLIENTE
            cbo_Producto.Items.Remove(cbo_Producto.SelectedItem);
            cbo_Producto.Items.Clear();
            nud_Cantidad.Value = 0;
            txt_Precio.Clear();
            //LIMPIAR TODOS LOS DATOS EXCEPTO LOS DEL VENDEDOR Y DEL CLIENTE
        }
    }
}
