using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpleadoDAL
    {
        public DataTable Iniciar_Sesion() { 
            Conexion conexion = new Conexion();
            
            //DEVUELVE LA DESCRIPCION DEL EMPLEADO,
            //EL USUARIO Y SU CONTRASEÑA PARA COMPARAR A LA HORA DE INICIAR SESION
            DataTable dt = conexion.LeerPorComando("select TE.descripcion, E.USUARIO, E.CONTRASEÑA from EMPLEADO E \r\nINNER JOIN TIPO_EMPLEADO TE on E.ID_EMPLEADO=TE.ID_TIPO_EMPLEADO");
            return dt;
        }
        public DataTable ListarEmpleados()
        {
            Conexion conexion = new Conexion();

            //DEVUELVE TODOS LOS EMPLEADOS
            DataTable dt = conexion.LeerPorComando("select E.ID_EMPLEADO, TE.ID_TIPO_EMPLEADO, TE.DESCRIPCION AS DESCRIPCION, E.NOMBRE, E.APELIDO, E.DNI, E.USUARIO, E.CONTRASEÑA from EMPLEADO E \r\nINNER JOIN TIPO_EMPLEADO TE on E.ID_TIPO_EMPLEADO=TE.ID_TIPO_EMPLEADO");
            return dt;
        }

        public object AgregarEmpleados()
        {
            Conexion conexion = new Conexion();

            //AGREGA UN NUEVO EMPLEADO
            
            DataTable dt = conexion.LeerPorComando("insert into empleado (id_empleado,id_tipo_empleado,nombre,apelido,dni,usuario,contraseña)\r\nvalues (5,4,'Claudio','Gonzalez','35695521','elclaudio','elgenio'))");
            return true;
        }
    }
}
