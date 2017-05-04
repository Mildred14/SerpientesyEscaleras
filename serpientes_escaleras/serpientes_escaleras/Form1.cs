using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serpientes_escaleras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Para jugar necesito dos jugadores y un tablero, así que lo inicializo
        Jugador j1= new Jugador("A");
        Jugador j2= new Jugador("B");
        Tablero t = new Tablero();
        private void button1_Click(object sender, EventArgs e)
        {
            while (j1.posicion < 100 & j2.posicion < 100)
            {//Para que el boton realice su accioón, instanciamos al tablero (t) y la acción que queremos que realice
             //Como parametros va a tener a su jugador y la posicion de su jugador. 
             //TODO LO ANTERIOR se va a guardar en la posicion del jugador
                j1.posicion = t.avanzar(j1.posicion);
                j2.posicion = t.avanzar(j2.posicion);
                //Todos los valores van a aparecer en el TextBox
                textBox1.Text += j1.ToString() + Environment.NewLine +
                    j2.ToString() + Environment.NewLine;
                //Si la posicion del jugador 1 es igual a 100 GANA
                if (j1.posicion == 100)
                    label4.Text = "A".ToString();
                //Sino la posicion del jugador 2 GANA
                else
                    label4.Text = " B".ToString();
            }
        }
    }
}
