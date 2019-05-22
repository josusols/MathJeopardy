//Librerias.
using System;

namespace MathJeopardy
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
