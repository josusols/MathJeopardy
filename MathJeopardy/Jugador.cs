//Librerias.
using System;

namespace Proyecto1_MathJeopardy_1036216
{
    public class Jugador
    {
        public string Nombre;
        public int Punteo;
        public bool Invicto;

        //Constructor.
        public Jugador(string nombre)
        {
            Nombre = nombre;
            Punteo = 0;
            Invicto = true;
        }
    }
}
