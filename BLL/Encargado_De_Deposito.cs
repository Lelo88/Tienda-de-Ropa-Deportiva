using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Encargado_De_Deposito : Empleado
    {
        public Encargado_De_Deposito() { 
        
        }
        public Encargado_De_Deposito(int id_empleado, string nombre, string apellido, string dni, Tipo_empleado tipoEmpleado, string usuario, string contrasena)
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
        public void Visualizar_Producto() { 
        
        }
        public void Agregar_Producto()
        {

        }
        public void Modificar_Producto()
        {

        }
        public void Eliminar_Producto()
        {

        }
    }
}
