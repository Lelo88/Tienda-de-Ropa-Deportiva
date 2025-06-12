using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Metodo_de_pago
    {
		private int id_mdp;

		public int Id_Mdp
		{
			get { return id_mdp; }
			set { id_mdp = value; }
		}
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		public Metodo_de_pago() { 
		
		}
        public Metodo_de_pago(int id_mdp, string nombre)
        {
            this.id_mdp = id_mdp;
            this.nombre = nombre;
        }

    }
}
