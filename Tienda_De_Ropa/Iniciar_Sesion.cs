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
    public partial class Iniciar_Sesion: Form
    {
        public Iniciar_Sesion()
        {
            InitializeComponent();
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
             
            DialogResult r = MessageBox.Show("¿Seguro que desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, false);
            if (r == DialogResult.Yes)
            {
                
                MessageBox.Show("Cerrando...");
                Application.Exit();
            }
            else {
                
                MessageBox.Show("El sistema seguira en funcionamiento");
            }
                
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            BLL.Tipo_empleado tipo_empleado1 = new BLL.Tipo_empleado(4, "Vendedor");
            BLL.Vendedor vendedor1 = new BLL.Vendedor(1, "Juan", "Perez", "12345678", tipo_empleado1, "juanperez", "contrasena123");
            BLL.Tipo_empleado tipo_empleado2 = new BLL.Tipo_empleado(3, "Gerente");
            BLL.Gerente gerente1 = new BLL.Gerente(2, "Maria", "Lopez", "87654321", tipo_empleado2, "marialopez", "contrasena456");
            BLL.Tipo_empleado tipo_empleado3 = new BLL.Tipo_empleado(2, "Encargado de deposito");
            BLL.Encargado_De_Deposito encargado1 = new BLL.Encargado_De_Deposito(3, "Carlos", "Gomez", "11223344", tipo_empleado3, "carlosgomez", "contrasena789");
            BLL.Tipo_empleado tipo_empleado4 = new BLL.Tipo_empleado(1, "Administrador");
            BLL.Administrador administrador1 = new BLL.Administrador(4, "Ana", "Martinez", "44332211", tipo_empleado4, "anamartinez", "contrasena101");
            if (string.IsNullOrEmpty(txt_Usuario.Text) || string.IsNullOrEmpty(txt_Contrasenia.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                
            }
            else {
                if (vendedor1.Usuario == txt_Usuario.Text && tipo_empleado1.Id_TipoEmpleado == 4 && vendedor1.Contrasenia == txt_Contrasenia.Text)
                {
                    this.Hide();
                    Vendedor vendedor = new Vendedor();
                    MessageBox.Show("BIENVENIDO ", vendedor1.Nombre + tipo_empleado1.Descripcion);
                    vendedor.Show();

                }
                else {
                    if (gerente1.Usuario == txt_Usuario.Text && tipo_empleado2.Id_TipoEmpleado == 3 && gerente1.Contrasenia == txt_Contrasenia.Text)
                    {
                        this.Hide();
                        Gerente gerente = new Gerente();
                        MessageBox.Show("BIENVENIDO ", gerente1.Nombre + tipo_empleado2.Descripcion);
                        gerente.Show();
                    }
                    else {
                        if (encargado1.Usuario == txt_Usuario.Text && tipo_empleado3.Id_TipoEmpleado == 2 && encargado1.Contrasenia == txt_Contrasenia.Text)
                        {
                            this.Hide();
                            EncargadoDeDeposito encargado = new EncargadoDeDeposito();
                            MessageBox.Show("BIENVENIDO ", encargado1.Nombre + tipo_empleado3.Descripcion);
                            encargado.Show();
                        }
                        else {
                            if (administrador1.Usuario == txt_Usuario.Text && tipo_empleado4.Id_TipoEmpleado == 1 && administrador1.Contrasenia == txt_Contrasenia.Text)
                            {
                                this.Hide();
                                Administrador administrador = new Administrador();
                                MessageBox.Show("BIENVENIDO ", administrador1.Nombre + tipo_empleado4.Descripcion);
                                administrador.Show();
                            }
                            else {
                                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS");
                            }
                        }
                    }
                }
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Iniciar_Sesion_Load(object sender, EventArgs e)
        {

        }
        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Iniciar.PerformClick();
                e.Handled = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                btn_Salir.PerformClick();  
            }
        }
        
        

}
}
