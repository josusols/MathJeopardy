//Librerias.
using System;
using System.Collections.Generic;

namespace MathJeopardy.Categorías
{
    public static class ProblemasMatematicos
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
            //Pregunta.
            Nivel1.Add(
                "En un cine hay 54 hombres, 74 mujeres y 12 niños. \n\n" +
                
                "¿Cuántas butacas se han ocupado si el cine tiene 300 butacas?"
                );
            RNivel1.Add(140); //Respuesta.

            //Pregunta.
            Nivel1.Add(
                "En un cine hay 54 hombres, 74 mujeres y 12 niños. \n\n" +
                
                "¿Cuántas butacas se han quedado libres si el cine tiene 300 butacas?"
                );
            RNivel1.Add(160); //Respuesta.

            //Pregunta.
            Nivel1.Add(
                "En el cuartel hay 426 soldados. Han llegado 318 soldados\n" +
                "más y se han ido 26. \n\n" +
                
                "¿Cuántos hay ahora?"
                );
            RNivel1.Add(718); //Respuesta.

            //Pregunta.
            Nivel1.Add(
                "A una niña por su cumpleaños le regalan dinero, su padre\n" +
                "le da 100, su madre 50, su abuela 65. Si se compra un \n" +
                "chocolate que le cuesta 65. \n\n" +
                
                "¿Cuánto le queda?"
                );
            RNivel1.Add(150); //Respuesta.

            //Pregunta.
            Nivel1.Add(
                "En un vaso ponemos 0.12 litros de agua, en otro vaso\n" +
                "0.18 y en otro 0.17. \n\n" +
                
                "¿Cuánto hay entre los tres?"
                );
            RNivel1.Add(0.47); //Respuesta.

            //Pregunta.
            Nivel1.Add(
                "El padre de Juan entregó 10.75 euros a sus cinco hijos. \n\n" +
                
                "¿Cuánto le tocó a cada uno?"
                );
            RNivel1.Add(2.15); //Respuesta.
        }

        //Configuración del nivel 2.
        private static void LlenarN2()
        {
            //Pregunta.
            Nivel2.Add(
                "Alejandro tiene 600 canicas y como se va a ir a vivir\n" +
                "a Guadalajara se las va a regalar a sus 12 amigos en\n" +
                "partes iguales. \n\n"+
                
                "¿Cuántas canicas le dará a cada amigo?"
                );
            RNivel2.Add(50); //Respuesta.

            //Pregunta.
            Nivel2.Add(
                "¿Cuál es la cantidad de losetas que caben en un piso que\n" +
                "tiene 5 losetas de largo por 4 losetas de ancho?"
                );
            RNivel2.Add(20); //Respuesta.

            //Pregunta.
            Nivel2.Add(
                "Toño compró un ordenador por 512 y tiene que pagar 68 por\n" +
                "adelantado. \n\n" +

                "¿Cuanto resta por pagar?"
                );
            RNivel2.Add(444); //Respuesta.

            //Pregunta.
            Nivel2.Add(
                "Mariana quiere saber cuánto tiene que pagar cada mes, durante\n" +
                "un año, por una moto que le costó 4320"
                );
            RNivel2.Add(360); //Respuesta.

            //Pregunta.
            Nivel2.Add(
                "Lupe tiene 18 cajas con 150 canicas en cada una. \n\n" +
                "¿Cuántas canicas tiene en total?"
                );
            RNivel2.Add(2700); //Respuesta.

            //Pregunta.
            Nivel2.Add(
                "Karmina compró un paquete de libros de $2,500 en 18 mensualidades. \n\n" +
                "¿Cuánto tiene que pagar cada mes?"
                );
            RNivel2.Add(138.89); //Respuesta.
        }

        //Configuración del nivel 3.
        private static void LlenarN3()
        {
            //Pregunta.
            Nivel3.Add(
                "Una hormiga llega a 6/10 de su camino. Si se divide el\n" +
                "camino en quintos. \n\n" +

                "¿Qué fracción representa el recorrido de la hormiga?"
                );
            RNivel3.Add(0.6); //Respuesta.

            //Pregunta.
            Nivel3.Add(
                "En el festival de navidad de la escuela, el teatro se\n" +
                "fue llenando por partes. Primero llegaron 2/9 partes\n" +
                "de espectadores, después entraron 3/9 y, por último, \n" +
                "entraron 1/9 partes de espectadores\n\n" +
                
                "¿Qué parte del teatro se ocupó?"
                );
            RNivel3.Add(0.67); //Respuesta.

            //Pregunta.
            Nivel3.Add(
                "Un paquete contenía 6/8 de kilogramo de harina y se\n" +
                "utilizaron 2/8 de kilogramo para hacer un pastel\n\n" +
                
                "¿Cuánta harina quedó en el paquete?"
                );
            RNivel3.Add(0.5); //Respuesta.

            //Pregunta.
            Nivel3.Add(
                "En una prueba de salto de longitud Silvia saltó 1,5 m \n" +
                "en su primera oportunidad, 1,75 m en la segunda y 2,3 m \n" +
                "en su último salto. Si el record de 3 saltos está en 5,80 m \n\n" +
                
                "¿Cuánto le faltó para alcanzarlo?"
                );
            RNivel3.Add(0.25); //Respuesta.

            //Pregunta.
            Nivel3.Add(
                "Iván tenía ahorrado 20,80 y Vanessa le pidió 12,32\n\n" +
                
                "¿Cuánto dinero le quedó a Iván?"
                );
            RNivel3.Add(8.48); //Respuesta.

            //Pregunta.
            Nivel3.Add(
                "Estefanìa tenía ahorrado $2,250 pesos y compró un juguete\n" +
                "que le costó $790 pesos\n\n" +
                
                "¿Cuánto dinero le quedó?"
                );
            RNivel3.Add(1460); //Respuesta.
        }

        //Configuración del nivel 4.
        private static void LlenarN4()
        {
            //Pregunta.
            Nivel4.Add(
                "Juan tiene 85 y se ha comprado una chocolatina que le\n" +
                "costó 35 y unos caramelos que le costaron 25. \n\n" +
                
                "¿Cuánto dinero le sobrará?"
                );
            RNivel4.Add(25); //Respuesta.

            //Pregunta.
            Nivel4.Add(
                "Compró un bote de mermelada de 52 y una lata de sardinas de 36. \n\n" +
                
                "¿Cuánto gastó?"
                );
            RNivel4.Add(88); //Respuesta.

            //Pregunta.
            Nivel4.Add(
                "Compró un bote de mermelada de 52 y una lata de sardinas de 36. \n" +
                "Si pagó con un billete de 100. \n\n" +
                
                "¿Cuánto le devolvieron?"
                );
            RNivel4.Add(12); //Respuesta.

            //Pregunta.
            Nivel4.Add(
                "Tenía 95, compré un balón de 68 y un chocolate de 24. \n\n" +
                
                "¿Cuántas pesetas me sobraron?"
                );
            RNivel4.Add(3); //Respuesta.

            //Pregunta.
            Nivel4.Add(
                "Germán tiene 12 cromos y Luis tiene 17. \n\n" +
                
                "¿Cuántos tienen entre los dos?"
                );
            RNivel4.Add(29); //Respuesta.

            //Pregunta.
            Nivel4.Add(
                "Germán tiene 12 cromos y Luis tiene 17. \n\n" + 
                
                "¿Cuántos cromos tiene Luis más que Germán?"
                );
            RNivel4.Add(5); //Respuesta.
        }

        //Configuración del nivel 5.
        private static void LlenarN5()
        {
            //Pregunta.
            Nivel5.Add(
                "Uno de los docentes de matemática, se graduó de\n" +
                "secundaria en el año que satisface las siguientes\n" +
                "condiciones: \n\n" +

                "-La suma de sus dígitos es 23. \n" +
                "-El dígito de las centenas es tres más que el de\n" +
                "las decenas. \n" +
                "-Ningún dígito es ocho. \n\n" +

                "¿En qué año se graduó dicho docente?"
                );
            RNivel5.Add(1967); //Respuesta.

            //Pregunta.
            Nivel5.Add(
                "Hay un número de dos dígitos entre 20 y 30, tal que\n" +
                "la suma de los cubos de sus dígitos es tres veces\n" +
                "el número."
                );
            RNivel5.Add(24); //Respuesta.

            //Pregunta.
            Nivel5.Add(
                "En una granja avícola se producen 12384 pollitos,\n" +
                "los mismos que serán transportados en cajas con\n" +
                "ventilación en las que caben 96 pollitos. \n\n" +

                "¿Cuántas cajas se necesitan para transportar a todos\n" +
                "los pollitos?"
                );
            RNivel5.Add(129); //Respuesta.

            //Pregunta.
            Nivel5.Add(
                "Un paquete contenía 6 / 8 de kilogramo de harina y\n" +
                "se utilizaron 2 / 8 de kilogramo para hacer un pastel\n\n" +

                "¿Cuánta harina quedó en el paquete?"
                );
            RNivel5.Add(0.5); //Respuesta.

            //Pregunta.
            Nivel5.Add(
                "La profesora de lenguaje dejó de tarea que en 15 días\n" +
                "sus alumnos completaran 5 horas de lectura cada uno. \n\n" +

                "¿Cuántos minutos diarios tiene que leer cada niño?"
                );
            RNivel5.Add(300); //Respuesta.

            //Pregunta.
            Nivel5.Add(
                "¿Qué edad tendrá Juan en el año 2000 sabiendo que esa\n" +
                "edad será igual a la suma de las cuatro cifras de su\n" +
                "año de nacimiento."
                );
            RNivel5.Add(19); //Respuesta.
        }
    }
}
