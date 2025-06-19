using DAL;
using System;
using System.Collections.Generic;
using System.Data;
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

        public override bool Iniciar_Sesion(string user, string pass)
        {
            DAL.EmpleadoDAL empleadoDAL = new DAL.EmpleadoDAL();
            DataTable dt = empleadoDAL.Iniciar_Sesion();

            foreach (DataRow fila in dt.Rows)
            {
                if (fila["USUARIO"].Equals(user) && fila["CONTRASEÑA"].Equals(pass) && fila["DESCRIPCION"].Equals("Administrador"))
                {
                    return true;
                }
            }
            return false;

        }

        public object Listar_empleados()
        {
            DAL.EmpleadoDAL empleadoDAL = new DAL.EmpleadoDAL();
            DataTable dt = empleadoDAL.ListarEmpleados();
            foreach (DataRow fila in dt.Rows)
            {
                Console.WriteLine($"ID: {fila["ID_EMPLEADO"]}, " +
                    $"ID_TIPO_EMPLEADO: {fila["ID_TIPO_EMPLEADO"]}," +
                    $"DESCRIPCION: {fila["DESCRIPCION"]}," +
                    $"Nombre: {fila["NOMBRE"]}," +
                    $" Apellido: {fila["APELIDO"]}, " +
                    $"DNI: {fila["DNI"]}, " +
                    $"Usuario: {fila["USUARIO"]}" +
                    $"Contraseña: {fila["Contraseña"]}, ");
            }
            return dt;
        }
        public object Alta_de_empleado()
        {

            //FALTA ARREGLOS
            DAL.EmpleadoDAL empleadoDAL = new DAL.EmpleadoDAL();
            //DataTable dt = empleadoDAL.AgregarEmpleados();
            DataSet ds = new DataSet();
            DataTable dt = empleadoDAL.ListarEmpleados();
            foreach (DataRow fila in dt.Rows)
            {
                Console.WriteLine($"ID: {fila["ID_EMPLEADO"]}, " +
                    $"ID_TIPO_EMPLEADO: {fila["ID_TIPO_EMPLEADO"]}," +
                    $"Nombre: {fila["NOMBRE"]}," +
                    $" Apellido: {fila["APELIDO"]}, " +
                    $"DNI: {fila["DNI"]}, " +
                    $"Usuario: {fila["USUARIO"]}");
            }
            return dt;

            //FALTA ARREGLOS
        }
        public void Baja_de_empleado()
        {

        }
        public void Modificar_empleado()
        {

        }


    }
}
