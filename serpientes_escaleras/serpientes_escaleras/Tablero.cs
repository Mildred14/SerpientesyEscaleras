using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serpientes_escaleras
{
    class Tablero
    {
        //Se manda llamar la clase dado en privado porque si lo pones en público, cualquiera va a poder modificar su valor y NEL!
        private Dado d = new Dado();
        //Se declara un vector con el tamaño deseado, PERO esto no significa que ya esté hecho... TIENES que llenar tus vectores... 
        public int[] posicion = new int[100];
        //Tampoco olvides que tienes que hacer publico Dado porque ahí vas retornar su valor!!
        public Dado d1 { get { return d; } }
        //Como te dije tienes que llenar tus vectores, pero ¿dónde?, PUES EN EL TABLERO!! <3
        public Tablero()
        {
            //Con ayuda de un for empezamos a llenar tus vectores 
            for (int i = 0; i < 100; i++)
            {
                // JUSTAMENTE AQUI! Ojo: tienes que darle valor a tu posicion, recuerda que "i" equivale al valor de tu vector
                posicion[i] = i;
            }
            //En el mismo tablero vas a asignar tus serpientes y escaleras, dandole el valor que tendrá cada que llegue a esa casilla
            //Serpientes=bajar
            posicion[10] = 2;
            posicion[18] = 11;
            posicion[20] = 15;
            posicion[29] = 21;
            posicion[34] = 30;
            posicion[45] = 35;
            posicion[58] = 47;
            posicion[62] = 55;
            posicion[81] = 70;
            posicion[90] = 82;
            //Escaleras=subir
            posicion[3] = 9;
            posicion[14] = 32;
            posicion[19] = 38;
            posicion[22] = 42;
            posicion[33] = 48;
            posicion[44] = 59;
            posicion[50] = 67;
            posicion[65] = 72;
            posicion[73] = 80;
            posicion[91] = 98;

        }
        //Tu única funcion al jugar este juego, es avanzar y ganar, así de fácil
        //Así que tu función se va a llamar avanzar pero recuerda que como parámetro principal necesitas la posicion del jugador
        //Sin una posición no sabrás a donde avanzar, así que recuerda muy bien todo lo que tiene que realizar una función para que funcione
      public int avanzar(int posicionJugador)
        {
            //Declaramos una variable que reciba el valor del dado
            int n;
            //Asignamos a la variable "n" el valor del dado, recuerda que el dado debe tener la acción que laza el dado
            n = d.lanzar();
            //Dentro de la "PosicionJugador" DEBES saber que tendrá el valor que contenga "posicion", ya que a su vez el valor del vector será "PosicionJugador" + n (valor de dado) <3
            posicionJugador = posicion[posicionJugador+n];
            return posicionJugador;
        }
       
    }
}
