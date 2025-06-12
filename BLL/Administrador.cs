using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Administrador : Empleado
    {
        public Administrador()
        {

        }
        public Administrador(int id_empleado, string nombre, string apellido, string dni, Tipo_empleado tipoEmpleado, string usuario, string contrasena)
        {
            this.Id_Empleado = id_empleado;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Tipo_Empleado = tipoEmpleado;
            this.Usuario = usuario;
            this.Contrasenia = contrasena;
        }

        public override void Iniciar_Sesion()
        {
            
        }
        public override void Cerrar_Sesion()
        {

        }
        public void Alta_de_empleado() { 
        
        }
        public void Baja_de_empleado()
        {

        }
        public void Modificar_empleado()
        {

        }
        public void Lista_empleado()
        {

        }
    }
}
