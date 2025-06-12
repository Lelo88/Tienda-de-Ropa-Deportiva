using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Deporte
    {
        private int id_deporte;

        public int Id_Deporte
        {
            get { return id_deporte; }
            set { id_deporte = value; }
        }
        
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Deporte() { 
        
        }
        public Deporte(int id_deporte, string nombre)
        {
            this.id_deporte = id_deporte;
            this.nombre = nombre;
        }
    }
}
