using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serpientes_escaleras
{
    class Jugador
    {
        
        private string _nombre;
        private int _posicion;
        public int posicion
        {
            set { _posicion = value; }
            get { return _posicion; }
        }
        public string nombre
        {
            get { return _nombre; }
        }
        public Jugador(string nombre)
        {
            _nombre = nombre;
            _posicion = 0;
        }
       
        public override string ToString()
        {
            return _nombre + " "+posicion.ToString();
        }
    }
}
