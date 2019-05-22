//Librerias.
using System;
using System.Collections.Generic;

namespace MathJeopardy.Categorías
{
    public static class CorreccionExpresionesMatematicas
    {
        //Lista de preguntas y respuestas Nivel 1, categoria corrección de expresiones matemáticas.
        public static List<String> Nivel1 = new List<String>();
        public static List<double> RNivel1 = new List<double>();

        //Lista de preguntas y respuestas Nivel 2, categoria corrección de expresiones matemáticas.
        public static List<String> Nivel2 = new List<String>();
        public static List<double> RNivel2 = new List<double>();

        //Lista de preguntas y respuestas Nivel 3, categoria corrección de expresiones matemáticas.
        public static List<String> Nivel3 = new List<String>();
        public static List<double> RNivel3 = new List<double>();

        //Lista de preguntas y respuestas Nivel 4, categoria corrección de expresiones matemáticas.
        public static List<String> Nivel4 = new List<String>();
        public static List<double> RNivel4 = new List<double>();

        //Lista de preguntas y respuestas Nivel 5, categoria corrección de expresiones matemáticas.
        public static List<String> Nivel5 = new List<String>();
        public static List<double> RNivel5 = new List<double>();

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
            Nivel1.Add("-22 - (?) + -14 = -15"); //Pregunta.
            RNivel1.Add(-21); //Respuesta.

            Nivel1.Add("29 + -14 + (?) = 29"); //Pregunta.
            RNivel1.Add(14); //Respuesta.

            Nivel1.Add("46 + (?) = 33"); //Pregunta.
            RNivel1.Add(-13); //Respuesta.

            Nivel1.Add("(?) - 28 = -48"); //Pregunta.
            RNivel1.Add(-20); //Respuesta.

            Nivel1.Add("-11 - (?) = -60"); //Pregunta.
            RNivel1.Add(49); //Respuesta.

            Nivel1.Add("45 - (?) = 0"); //Pregunta.
            RNivel1.Add(45); //Respuesta.
        }

        //Configuración del nivel 2.
        private static void LlenarN2()
        {
            Nivel2.Add("(?) / 7 = 7"); //Pregunta.
            RNivel2.Add(49); //Respuesta.

            Nivel2.Add("12 / (?) = 3"); //Pregunta.
            RNivel2.Add(4); //Respuesta.

            Nivel2.Add("(?) * 4 = 176"); //Pregunta.
            RNivel2.Add(44); //Respuesta.

            Nivel2.Add("(?) * -43 = 430"); //Pregunta.
            RNivel2.Add(-10); //Respuesta.

            Nivel2.Add("-10 * (?) = -380"); //Pregunta.
            RNivel2.Add(38); //Respuesta.

            Nivel2.Add("30 / (?) = 3"); //Pregunta.
            RNivel2.Add(10); //Respuesta.
        }

        //Configuración del nivel 3.
        private static void LlenarN3()
        {
            Nivel3.Add("(3V216) + (?) = 11"); //Pregunta.
            RNivel3.Add(5); //Respuesta.

            Nivel3.Add("(?) + (5^4) = 633"); //Pregunta.
            RNivel3.Add(8); //Respuesta.

            Nivel3.Add("(4V1296) - (?) = 2"); //Pregunta.
            RNivel3.Add(4); //Respuesta.

            Nivel3.Add("(?) + (3V512) = 14"); //Pregunta.
            RNivel3.Add(6); //Respuesta.

            Nivel3.Add("2V? = 2"); //Pregunta.
            RNivel3.Add(4); //Respuesta.

            Nivel3.Add("(?) + (3V343) = 56"); //Pregunta.
            RNivel3.Add(49); //Respuesta.
        }

        //Configuración del nivel 4.
        private static void LlenarN4()
        {
            Nivel4.Add("(?^4) * (9^0) = 6561"); //Pregunta.
            RNivel4.Add(9); //Respuesta.

            Nivel4.Add("(?^2) * (6^1) = 486"); //Pregunta.
            RNivel4.Add(9); //Respuesta.

            Nivel4.Add("(4V?) * (4V1296) = 30"); //Pregunta.
            RNivel4.Add(625); //Respuesta.

            Nivel4.Add("(8^4) / (?^1) = 819.2"); //Pregunta.
            RNivel4.Add(5); //Respuesta.

            Nivel4.Add("(6^4) / (2V?) = 324"); //Pregunta.
            RNivel4.Add(16); //Respuesta.

            Nivel4.Add("(6^?) * (2V4) = 2"); //Pregunta.
            RNivel4.Add(0); //Respuesta.
        }

        //Configuración del nivel 5.
        private static void LlenarN5()
        {
            Nivel5.Add("? * 2 - -29 + -31 / 47 = 62.34"); //Pregunta.
            RNivel5.Add(17); //Respuesta.

            Nivel5.Add("29 + ? - 25 * -34 / -3 = -275.33"); //Pregunta.
            RNivel5.Add(-21); //Respuesta.

            Nivel5.Add("-32 * 36 + ? / -32 - 24 = -1176.19"); //Pregunta.
            RNivel5.Add(6); //Respuesta.

            Nivel5.Add("? * 4 + -1 / 5 - 3 = -171.2"); //Pregunta.
            RNivel5.Add(-42); //Respuesta.

            Nivel5.Add("-6 * 48 - 39 + 29 / ? = -319.75"); //Pregunta.
            RNivel5.Add(4); //Respuesta.

            Nivel5.Add("-6 * ? - 39 + 29 / 4 = -319.75"); //Pregunta.
            RNivel5.Add(48); //Respuesta.
        }
    }
}
