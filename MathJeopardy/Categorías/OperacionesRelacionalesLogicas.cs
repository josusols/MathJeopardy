//Librerias.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_MathJeopardy_1036216.Categorías
{
    static class OperacionesRelacionalesLogicas
    {
        //Lista de preguntas y respuestas Nivel 1, categoria corrección de expresiones matemáticas.
        public static List<String> Nivel1 = new List<String>();
        public static List<String> RNivel1 = new List<String>();

        //Lista de preguntas y respuestas Nivel 2, categoria corrección de expresiones matemáticas.
        public static List<String> Nivel2 = new List<String>();
        public static List<String> RNivel2 = new List<String>();

        //Lista de preguntas y respuestas Nivel 3, categoria corrección de expresiones matemáticas.
        public static List<String> Nivel3 = new List<String>();
        public static List<String> RNivel3 = new List<String>();

        //Lista de preguntas y respuestas Nivel 4, categoria corrección de expresiones matemáticas.
        public static List<String> Nivel4 = new List<String>();
        public static List<String> RNivel4 = new List<String>();

        //Lista de preguntas y respuestas Nivel 5, categoria corrección de expresiones matemáticas.
        public static List<String> Nivel5 = new List<String>();
        public static List<String> RNivel5 = new List<String>();

        //Configuración de la categoria aritmetica.
        public static void Configurar()
        {
            //Manda a llamar a la configuración del nivel 1.
            LlenarN1();
            //Manda a llamar a la configuración del nivel 2.
            LlenarN2();
            //Manda a llamar a la configuración del nivel 3.
            LlenarN3();
            //Manda a llamar a la configuración del nivel 4.
            LlenarN4();
            //Manda a llamar a la configuración del nivel 5.
            LlenarN5();
        }

        //Configuración del nivel 1.
        private static void LlenarN1()
        {
            //Pregunta.
            Nivel1.Add(
                "Si Ángela habla más bajo que Rosa y Celia habla más alto que\n" +
                "Rosa\n\n" +
                
                "¿Habla Ángela más alto o más bajo que Celia?"
                );
            RNivel1.Add("habla mas bajo"); //Respuesta.
        }

        //Configuración del nivel 2.
        private static void LlenarN2()
        {
            //Pregunta.
            Nivel2.Add(
                "La nota media conseguida en una clase de 20 alumnos ha sido de\n" +
                "6. Ocho alumnos han suspendido con un 3 y el resto superó el 5. \n\n" +
                
                "¿Cuál es la nota media de los alumnos aprobados?"
                );
            RNivel2.Add("8"); //Respuesta.
        }

        //Configuración del nivel 3.
        private static void LlenarN3()
        {
            //Pregunta.
            Nivel3.Add(
                "Seis amigos desean pasar sus vacaciones juntos y deciden, cada\n" +
                "dos, utilizar diferentes medios de transporte. Sabemos que Alejandro\n" +
                "no utiliza el coche ya que éste acompaña a Benito que no va en avión. \n" +
                "Andrés viaja en avión. Si Carlos no va acompañado de Darío ni hace uso\n" +
                "del avión.\n\n" +

                "¿En qué medio de transporte llega a su destino Tomás?"
                );
            RNivel3.Add("en carro"); //Respuesta.
        }

        //Configuración del nivel 4.
        private static void LlenarN4()
        {
            //Pregunta.
            Nivel4.Add(
                "El caballo de Mac es más oscuro que el de Smith, pero más rápido\n" +
                "y más viejo que el de Jack, que es aún más lento que el de Willy, \n" +
                "que es más joven que el de Mac, que es más viejo que el de Smith, \n" +
                "que es más claro que el de Willy, aunque el de Jack es más lento y\n" +
                "más oscuro que el de Smith. \n\n" +
                
                "¿Cuál es el más viejo, cuál el más lento y cuál el más claro?"
                );
            RNivel4.Add("El más viejo el de Mac, el más lento el de Jack y el más claro el de Smith"); //Respuesta.
        }

        //Configuración del nivel 5.
        private static void LlenarN5()
        {
            //Pregunta.
            Nivel5.Add(
                "Tenemos cuatro perros: un galgo, un dogo, un alano y un podenco. \n" +
                "Éste último come más que el galgo; el alano come más que el galgo\n" +
                "y menos que el dogo, pero éste come más que el podenco. \n\n" +
                
                "¿Cuál de los cuatro será más barato de mantener?"
                );
            RNivel5.Add("el galgo"); //Respuesta.
        }
    }
}
