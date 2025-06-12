﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Tipo_empleado
    {
		private int id_tipoEmpleado;

		public int Id_TipoEmpleado
		{
			get { return id_tipoEmpleado; }
			set { id_tipoEmpleado = value; }
		}
		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		public Tipo_empleado() { 
		
		}

		public Tipo_empleado(int id_tipoEmpleado, string descripcion) { 
			this.id_tipoEmpleado=id_tipoEmpleado;
			this.descripcion=descripcion;
		}
	}
}
