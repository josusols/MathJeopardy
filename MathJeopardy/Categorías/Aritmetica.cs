//Librerias.
using System;
using System.Collections.Generic;

namespace MathJeopardy.Categorías
{
    public static class Aritmetica
    {
        //Número aleatorio.
        private static Random n = new Random();
        //Lista de números aleatorios que podra utilizar en todos los niveles.
        private static List<double> numero = new List<double>();

        //Lista de preguntas y respuestas Nivel 1, categoria aritmetica.
        public static List<String> Nivel1 = new List<String>();
        public static List<double> RNivel1 = new List<double>();

        //Lista de preguntas y respuestas Nivel 2, categoria aritmetica.
        public static List<String> Nivel2 = new List<String>();
        public static List<double> RNivel2 = new List<double>();

        //Lista de preguntas y respuestas Nivel 3, categoria aritmetica.
        public static List<String> Nivel3 = new List<String>();
        public static List<double> RNivel3 = new List<double>();
    
        //Lista de preguntas y respuestas Nivel 4, categoria aritmetica.
        public static List<String> Nivel4 = new List<String>();
        public static List<double> RNivel4 = new List<double>();

        //Lista de preguntas y respuestas Nivel 5, categoria aritmetica.
        public static List<String> Nivel5 = new List<String>();
        public static List<double> RNivel5 = new List<double>();

        //Configuración de la categoria aritmetica.
        public static void Configurar()
        {
            //Se generan 100 números aleatorios en el intervalo [-50, 50].
            for (int i = 0; i < 50; i++)
            {
                numero.Add(n.Next(1, 50));
                numero.Add(-1 * (n.Next(1, 50)));
            }

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
            //Números a utilizar en las preguntas.
            int n1, n2, n3;

            //Tabla de 30 opciones disponibles para el nivel 1.
            for (int i = 0; i < 5; i++)
            {
                //Suma de 2 números.
                n1 =n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel1.Add("X = " + numero[n1] + " + " + numero[n2] + ":"); //Pregunta.
                RNivel1.Add(numero[n1] + numero[n2]); //Respuesta.

                //Suma de 3 números.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel1.Add("X = " + numero[n1] + " + " + numero[n2] + " + " + numero[n3] + ":"); //Pregunta.
                RNivel1.Add(numero[n1] + numero[n2] + numero[n3]); //Respuesta.

                //Resta de 2 números.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel1.Add("X = " + numero[n1] + " - " + numero[n2] + ":"); //Pregunta.
                RNivel1.Add(numero[n1] - numero[n2]); //Respuesta.

                //Resta de 3 números.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel1.Add("X = " + numero[n1] + " - " + numero[n2] + " - " + numero[n3] + ":"); //Pregunta.
                RNivel1.Add(numero[n1] - numero[n2] - numero[n3]); //Respuesta.

                //Suma y Resta de 3 números.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel1.Add("X = " + numero[n1] + " + " + numero[n2] + " - " + numero[n3] + ":"); //Pregunta.
                RNivel1.Add(numero[n1] + numero[n2] - numero[n3]); //Respuesta.

                //Resta y Suma de 3 números.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel1.Add("X = " + numero[n1] + " - " + numero[n2] + " + " + numero[n3] + ":"); //Pregunta.
                RNivel1.Add(numero[n1] - numero[n2] + numero[n3]); //Respuesta.
            }
        }

        //Configuración del nivel 2.
        private static void LlenarN2()
        {
            //Números a utilizar en las preguntas.
            int n1, n2, n3;

            //Tabla de 30 opciones disponibles para el nivel 2.
            for (int i = 0; i < 5; i++)
            {
                //Multiplicación de 2 números.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel2.Add("X = " + numero[n1] + " * " + numero[n2] + ":"); //Pregunta.
                RNivel2.Add(numero[n1] * numero[n2]); //Respuesta.

                //Multiplicación de 3 números.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel2.Add("X = " + numero[n1] + " * " + numero[n2] + " * " + numero[n3] + ":"); //Pregunta.
                RNivel2.Add(numero[n1] * numero[n2] * numero[n3]); //Respuesta.

                //División de 2 números.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel2.Add("X = " + numero[n1] + " / " + numero[n2] + ":"); //Pregunta.
                RNivel2.Add(Convert.ToDouble(Decimal.Round(Convert.ToDecimal(numero[n1] / numero[n2]),2))); //Respuesta.

                //División de 3 números.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel2.Add("X = " + numero[n1] + " / " + numero[n2] + " / " + numero[n3] + ":"); //Pregunta.
                RNivel2.Add(Convert.ToDouble(Decimal.Round(Convert.ToDecimal(numero[n1] / numero[n2] / numero[n3]),2))); //Respuesta.

                //Multiplicación y División de 3 números.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel2.Add("X = " + numero[n1] + " * " + numero[n2] + " / " + numero[n3] + ":"); //Pregunta.
                RNivel2.Add(Convert.ToDouble(Decimal.Round(Convert.ToDecimal(numero[n1] * numero[n2] / numero[n3]),2))); //Respuesta.

                //División y Multiplicación de 3 números.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel2.Add("X = " + numero[n1] + " / " + numero[n2] + " * " + numero[n3] + ":"); //Pregunta.
                RNivel2.Add(Convert.ToDouble(Decimal.Round(Convert.ToDecimal(numero[n1] / numero[n2] * numero[n3]),2))); //Respuesta.
            }
        }

        //Configuración del nivel 3.
        private static void LlenarN3()
        {
            //Números a utilizar en las preguntas.
            int n1, n2, n3, n4;

            //Tabla de 30 opciones disponibles para el nivel 3.
            for (int i = 0; i < 5; i++)
            {
                //Potencia de 1 número.
                n1 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n2 = n.Next(0, 5); //Número aleatorio en el intervalo [0 - 5].
                Nivel3.Add("X = " + n1 + "^" + n2 + ":"); //Pregunta.
                RNivel3.Add(Math.Pow(n1, n2)); //Respuesta.

                //Suma de 2 potencias.
                n1 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n2 = n.Next(0, 5); //Número aleatorio en el intervalo [0 - 5].
                n3 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n4 = n.Next(0, 5); //Número aleatorio en el intervalo [0 - 5].
                Nivel3.Add("X = (" + n1 + "^" + n2 + ") + (" + n3 + "^" + n4 + "):"); //Pregunta.
                RNivel3.Add(Math.Pow(n1, n2) + Math.Pow(n3, n4)); //Respuesta.

                //Raíz de 1 número.
                n1 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n2 = n.Next(2, 5); //Número aleatorio en el intervalo [2 - 5].
                Nivel3.Add("X = " + n2 + "√" + Math.Pow(n1, n2) + ":"); //Pregunta.
                RNivel3.Add(n1); //Respuesta.

                //Suma de 2 raices.
                n1 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n2 = n.Next(2, 5); //Número aleatorio en el intervalo [2 - 5].
                n3 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n4 = n.Next(2, 5); //Número aleatorio en el intervalo [2 - 5].
                Nivel3.Add("X = (" + n2 + "√" + Math.Pow(n1, n2) + ") + (" + n4 + "√" + Math.Pow(n3, n4) + "):"); //Pregunta.
                RNivel3.Add(n1 + n3); //Respuesta.

                //Suma de una potencia y una raíz.
                n1 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n2 = n.Next(0, 5); //Número aleatorio en el intervalo [0 - 5].
                n3 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n4 = n.Next(2, 5); //Número aleatorio en el intervalo [2 - 5].
                Nivel3.Add("X = (" + n1 + "^" + n2 + ") + (" + n4 + "√" + Math.Pow(n3, n4) + "):"); //Pregunta.
                RNivel3.Add(Math.Pow(n1, n2) + n3); //Respuesta.

                //Resta de una raíz y una potencia.
                n1 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n2 = n.Next(0, 5); //Número aleatorio en el intervalo [0 - 5].
                n3 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n4 = n.Next(2, 5); //Número aleatorio en el intervalo [2 - 5].
                Nivel3.Add("X = (" + n4 + "√" + Math.Pow(n3, n4) + ") - (" + n1 + "^" + n2 + "):"); //Pregunta.
                RNivel3.Add(n3 - Math.Pow(n1, n2)); //Respuesta.
            }
        }

        //Configuración del nivel 4.
        private static void LlenarN4()
        {
            //Números a utilizar en las preguntas.
            int n1, n2, n3, n4;

            //Tabla de 30 opciones disponibles para el nivel 4.
            for (int i = 0; i < 5; i++)
            {
                //Multiplicación de 2 potencias.
                n1 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n2 = n.Next(0, 5); //Número aleatorio en el intervalo [0 - 5].
                n3 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n4 = n.Next(0, 5); //Número aleatorio en el intervalo [0 - 5].
                Nivel4.Add("X = (" + n1 + "^" + n2 + ") * (" + n3 + "^" + n4 + "):"); //Pregunta.
                RNivel4.Add(Math.Pow(n1, n2) * Math.Pow(n3, n4)); //Respuesta.

                //División de 2 potencias.
                n1 = n.Next(1, 10); //Número aleatorio en el intervalo [1 - 10].
                n2 = n.Next(1, 5); //Número aleatorio en el intervalo [1 - 5].
                n3 = n.Next(1, 10); //Número aleatorio en el intervalo [1 - 10].
                n4 = n.Next(1, 5); //Número aleatorio en el intervalo [1 - 5].
                Nivel4.Add("X = (" + n1 + "^" + n2 + ") / (" + n3 + "^" + n4 + "):"); //Pregunta.
                RNivel4.Add(Convert.ToDouble(Decimal.Round(Convert.ToDecimal(Math.Pow(n1, n2) / Math.Pow(n3, n4)),2))); //Respuesta.
                
                //Multiplicación de 2 raices.
                n1 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n2 = n.Next(2, 5); //Número aleatorio en el intervalo [2 - 5].
                n3 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n4 = n.Next(2, 5); //Número aleatorio en el intervalo [2 - 5].
                Nivel4.Add("X = (" + n2 + "√" + Math.Pow(n1, n2) + ") * (" + n4 + "√" + Math.Pow(n3, n4) + "):"); //Pregunta.
                RNivel4.Add(n1 * n3); //Respuesta.

                //División de 2 raices.
                n1 = n.Next(1, 10); //Número aleatorio en el intervalo [1 - 10].
                n2 = n.Next(2, 5); //Número aleatorio en el intervalo [2 - 5].
                n3 = n.Next(1, 10); //Número aleatorio en el intervalo [1 - 10].
                n4 = n.Next(2, 5); //Número aleatorio en el intervalo [2 - 5].
                Nivel4.Add("X = (" + n2 + "√" + Math.Pow(n1, n2) + ") / (" + n4 + "√" + Math.Pow(n3, n4) + "):"); //Pregunta.
                RNivel4.Add(Convert.ToDouble(Decimal.Round(Convert.ToDecimal(n1 / n3),2))); //Respuesta.

                //Multiplicación de una potencia y una raíz.
                n1 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n2 = n.Next(0, 5); //Número aleatorio en el intervalo [0 - 5].
                n3 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n4 = n.Next(2, 5); //Número aleatorio en el intervalo [2 - 5].
                Nivel4.Add("X = (" + n1 + "^" + n2 + ") * (" + n4 + "√" + Math.Pow(n3, n4) + "):"); //Pregunta.
                RNivel4.Add(Math.Pow(n1, n2) * n3); //Respuesta.

                //División de una raíz y una potencia.
                n1 = n.Next(1, 10); //Número aleatorio en el intervalo [0 - 10].
                n2 = n.Next(0, 5); //Número aleatorio en el intervalo [1 - 5].
                n3 = n.Next(0, 10); //Número aleatorio en el intervalo [0 - 10].
                n4 = n.Next(2, 5); //Número aleatorio en el intervalo [2 - 5].
                Nivel4.Add("X = (" + n4 + "√" + Math.Pow(n3, n4) + ") / (" + n1 + "^" + n2 + "):"); //Pregunta.
                RNivel4.Add(Convert.ToDouble(Decimal.Round(Convert.ToDecimal(n3 / Math.Pow(n1, n2)),2))); //Respuesta.
            }
        }
        
        //Configuración del nivel 5.
        private static void LlenarN5()
        {
            //Números a utilizar en las preguntas.
            int n1, n2, n3, n4, n5;

            //Tabla de 30 opciones disponibles para el nivel 5.
            for (int i = 0; i < 5; i++)
            {
                //División, Suma, Resta y Multiplicación.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n4 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n5 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel5.Add("X = " + numero[n1] + " / " + numero[n2] + " + " + numero[n3] + " - " + numero[n4] + " * " + numero[n5] + ":"); //Pregunta.
                RNivel5.Add(Convert.ToDouble(Decimal.Round(Convert.ToDecimal(numero[n1] / numero[n2] + numero[n3] - numero[n4] * numero[n5]), 2))); //Respuesta.

                //Resta, División, Suma y Multiplicación.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n4 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n5 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel5.Add("X = " + numero[n1] + " - " + numero[n2] + " / " + numero[n3] + " + " + numero[n4] + " * " + numero[n5] + ":"); //Pregunta.
                RNivel5.Add(Convert.ToDouble(Decimal.Round(Convert.ToDecimal(numero[n1] - numero[n2] / numero[n3] + numero[n4] * numero[n5]), 2))); //Respuesta.

                //Suma, Resta, Multiplicación y División.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n4 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n5 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel5.Add("X = " + numero[n1] + " + " + numero[n2] + " - " + numero[n3] + " * " + numero[n4] + " / " + numero[n5] + ":"); //Pregunta.
                RNivel5.Add(Convert.ToDouble(Decimal.Round(Convert.ToDecimal(numero[n1] + numero[n2] - numero[n3] * numero[n4] / numero[n5]), 2))); //Respuesta.

                //Multiplicación, Suma, División y Resta.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n4 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n5 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel5.Add("X = " + numero[n1] + " * " + numero[n2] + " + " + numero[n3] + " / " + numero[n4] + " - " + numero[n5] + ":"); //Pregunta.
                RNivel5.Add(Convert.ToDouble(Decimal.Round(Convert.ToDecimal(numero[n1] * numero[n2] + numero[n3] / numero[n4] - numero[n5]), 2))); //Respuesta.

                //Suma, Multiplicación, Resta y División.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n4 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n5 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel5.Add("X = " + numero[n1] + " + " + numero[n2] + " * " + numero[n3] + " - " + numero[n4] + " / " + numero[n5] + ":"); //Pregunta.
                RNivel5.Add(Convert.ToDouble(Decimal.Round(Convert.ToDecimal(numero[n1] + numero[n2] * numero[n3] - numero[n4] / numero[n5]), 2))); //Respuesta.

                //Multiplicación, Resta, Suma y División.
                n1 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n2 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n3 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n4 = n.Next(100); //Número aleatorio de la lista de 200 números.
                n5 = n.Next(100); //Número aleatorio de la lista de 200 números.
                Nivel5.Add("X = " + numero[n1] + " * " + numero[n2] + " - " + numero[n3] + " + " + numero[n4] + " / " + numero[n5] + ":"); //Pregunta.
                RNivel5.Add(Convert.ToDouble(Decimal.Round(Convert.ToDecimal(numero[n1] * numero[n2] - numero[n3] + numero[n4] / numero[n5]), 2))); //Respuesta.
            }
        }
    }
}
