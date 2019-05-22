//Librerias.
using System;
using System.Timers;
using Proyecto1_MathJeopardy_1036216.Categorías;

namespace Proyecto1_MathJeopardy_1036216
{
    class Program
    {
        //Variables Globales.
        static string tempNombre, tempEleccion1, tempEleccion2; //Variable donde se almacena temporalmente un nombre, la elección de la categoria y la elección del nivel.

        static Jugador J1, J2; //Jugador 1 y 2 sin inicializar.

        static int contadorTurno; //Lleva el control de los turnos dentro de una ronda.
        static int contadorRonda;
        static int contadorAleatorio;
        static bool casillaEspecial = true;

        static Random Aleatorio = new Random();

        //Variables controladoras del tiempo.
        static int i = 20;
        static Timer timer = new Timer(1000);

        static string[,] tableroVisual = new string[6, 4]; //Tablero visual que se mostrará en pantalla.
        static bool[,] tableroLogico = new bool[5, 4]; //Tablero logico con el que trabaja el programa.

        //Método que verifica si el nombre ingresado no esta vacío.
        private static void VerificarNombre()
        {
            string entrada = Console.ReadLine();
            if (entrada != "") //Si es diferente a vacío lo guarda.
            {
                tempNombre = entrada;
                Console.WriteLine("¡Nombre aceptado!\n");
            }
            else //Si esta vacío vuelve a pedir el ingreso de datos.
            {
                Console.WriteLine("¡Ingrese un nombre correcto!");
                Console.Beep();
                VerificarNombre();
            }
        }

        //Método que verifica si la elección ingresada es valida.
        private static void VerificarEleccion1()
        {
            string entrada = Console.ReadLine();
            if (entrada == "a" || entrada == "A" || entrada == "b" || entrada == "B" || entrada == "c" || entrada == "C" || entrada == "d" || entrada == "D") //Si es igual a las opciones disponibles lo guarda.
            {
                tempEleccion1 = entrada;
                Console.WriteLine("¡Elección aceptada!\n");
            }
            else //Si esta vacío vuelve a pedir el ingreso de datos.
            {
                Console.WriteLine("\n¡Ingrese una opción valida!");
                Console.Beep();
                VerificarEleccion1();
            }
        }

        private static void VerificarEleccion2()
        {
            string entrada = Console.ReadLine();
            if (entrada == "100" || entrada == "200" || entrada == "300" || entrada == "400" || entrada == "500") //Si es igual a las opciones disponibles lo guarda.
            {
                tempEleccion2 = entrada;
                Console.WriteLine("¡Elección aceptada!\n");
            }
            else //Si esta vacío vuelve a pedir el ingreso de datos.
            {
                Console.WriteLine("\n¡Ingrese una opción valida");
                Console.Beep();
                VerificarEleccion2();
            }
        }

        //Método de bienvenida, lanza el título del juego y pide los nombres de los jugadores.
        private static void Bienvenida()
        {
            //Mensaje de bienvenida.
            Console.Title = "BIENVENIDO A MATH-JEOPARDY";

            Console.WriteLine("****************************");
            Console.WriteLine("*BIENVENIDO A MATH-JEOPARDY*");
            Console.WriteLine("****************************");

            //Registra el nombre del jugador 1.
            Console.WriteLine("-J1 ingrese su nombre:");
            VerificarNombre();
            J1 = new Jugador(tempNombre); //Inicializa al J1 y le asigna su nombre.

            //Registra el nombre del jugador 2.
            Console.WriteLine("-J2 ingrese su nombre:");
            VerificarNombre();
            J2 = new Jugador(tempNombre); //Inicializa al J2 y le asigna su nombre.
        }

        //Método que inicia los tableros visual y lógico.
        private static void IniciarTablero()
        {
            //TABLERO VISUAL.
            //Encabezado.
            tableroVisual[0, 0] = "A";
            tableroVisual[0, 1] = "B";
            tableroVisual[0, 2] = "C";
            tableroVisual[0, 3] = "D";

            //Nivel 1.
            tableroVisual[1, 0] = "100";
            tableroVisual[1, 1] = "100";
            tableroVisual[1, 2] = "100";
            tableroVisual[1, 3] = "100";

            //Nivel 2.
            tableroVisual[2, 0] = "200";
            tableroVisual[2, 1] = "200";
            tableroVisual[2, 2] = "200";
            tableroVisual[2, 3] = "200";

            //Nivel 3.
            tableroVisual[3, 0] = "300";
            tableroVisual[3, 1] = "300";
            tableroVisual[3, 2] = "300";
            tableroVisual[3, 3] = "300";

            //Nivel 4.
            tableroVisual[4, 0] = "400";
            tableroVisual[4, 1] = "400";
            tableroVisual[4, 2] = "400";
            tableroVisual[4, 3] = "400";

            //Nivel 5.
            tableroVisual[5, 0] = "500";
            tableroVisual[5, 1] = "500";
            tableroVisual[5, 2] = "500";
            tableroVisual[5, 3] = "500";

            //TABLERO LOGICO.
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tableroLogico[i, j] = true;
                }
            }
        }

        //Método que imprime en pantalla el tablero visual.
        private static void MostrarTablero()
        {
            Console.Title = "TABLERO DE MATH-JEOPARDY";
            Console.WriteLine("****************************");
            Console.WriteLine("*TABLERO DE MATH-JEOPARDY*");
            Console.WriteLine("****************************");

            //Instrucciones del tablero.
            Console.WriteLine("A: Operaciones aritméticas");
            Console.WriteLine("B: Operaciones relacionales");
            Console.WriteLine("C: Corrección de expresiones matemáticas");
            Console.WriteLine("D: Problemas matemáticos");

            Console.WriteLine("\nX: CASILLA DESCARTADA\n");
            
            //Tablero.
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("\t" + tableroVisual[i, j]);
                }
                Console.Write("\n");
            }
        }

        //Reset del tiempo.
        private static void ResetTiempo()
        {
            //Inicia el tiempo.
            i = 20;
            timer = new Timer(1000);
            Console.Title = "Time Remaining:  " + i.ToString();
            
            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        //Aritmetica N1:
        private static void AritmeticaN1(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            Aritmetica.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 29);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(Aritmetica.Nivel1[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == Aritmetica.RNivel1[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 100;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(Aritmetica.RNivel1[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(Aritmetica.RNivel1[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(Aritmetica.RNivel1[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }
        
        //Aritmetica N2:
        private static void AritmeticaN2(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            Aritmetica.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 29);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");

            Console.WriteLine(Aritmetica.Nivel2[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == Aritmetica.RNivel2[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 200;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(Aritmetica.RNivel2[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(Aritmetica.RNivel2[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(Aritmetica.RNivel2[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Aritmetica N3:
        private static void AritmeticaN3(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            Aritmetica.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 29);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(Aritmetica.Nivel3[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == Aritmetica.RNivel3[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 300;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(Aritmetica.RNivel3[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(Aritmetica.RNivel3[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(Aritmetica.RNivel3[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Aritmetica N4:
        private static void AritmeticaN4(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            Aritmetica.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 29);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(Aritmetica.Nivel4[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == Aritmetica.RNivel4[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 400;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(Aritmetica.RNivel4[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(Aritmetica.RNivel4[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(Aritmetica.RNivel4[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Aritmetica N5:
        private static void AritmeticaN5(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            Aritmetica.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 29);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(Aritmetica.Nivel5[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == Aritmetica.RNivel5[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 500;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(Aritmetica.RNivel5[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(Aritmetica.RNivel5[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(Aritmetica.RNivel5[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Problemas Matematicos N1:
        private static void OperacionesRelacionalesLogicasN1(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            OperacionesRelacionalesLogicas.Configurar();
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(OperacionesRelacionalesLogicas.Nivel1[0]);
            try
            {
                if (Console.ReadLine() == OperacionesRelacionalesLogicas.RNivel1[0])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 100;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(OperacionesRelacionalesLogicas.RNivel1[0]);
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(OperacionesRelacionalesLogicas.RNivel1[0]);
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(OperacionesRelacionalesLogicas.RNivel1[0]);
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Problemas Matematicos N2:
        private static void OperacionesRelacionalesLogicasN2(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            OperacionesRelacionalesLogicas.Configurar();
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(OperacionesRelacionalesLogicas.Nivel2[0]);
            try
            {
                if (Console.ReadLine() == OperacionesRelacionalesLogicas.RNivel2[0])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 200;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(OperacionesRelacionalesLogicas.RNivel2[0]);
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(OperacionesRelacionalesLogicas.RNivel2[0]);
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(OperacionesRelacionalesLogicas.RNivel2[0]);
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Problemas Matematicos N3:
        private static void OperacionesRelacionalesLogicasN3(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            OperacionesRelacionalesLogicas.Configurar();
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(OperacionesRelacionalesLogicas.Nivel3[0]);
            try
            {
                if (Console.ReadLine() == OperacionesRelacionalesLogicas.RNivel3[0])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 300;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(OperacionesRelacionalesLogicas.RNivel3[0]);
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(OperacionesRelacionalesLogicas.RNivel3[0]);
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(OperacionesRelacionalesLogicas.RNivel3[0]);
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Problemas Matematicos N4:
        private static void OperacionesRelacionalesLogicasN4(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            OperacionesRelacionalesLogicas.Configurar();
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(OperacionesRelacionalesLogicas.Nivel4[0]);
            try
            {
                if (Console.ReadLine() == OperacionesRelacionalesLogicas.RNivel4[0])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 400;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(OperacionesRelacionalesLogicas.RNivel4[0]);
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(OperacionesRelacionalesLogicas.RNivel4[0]);
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(OperacionesRelacionalesLogicas.RNivel4[0]);
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Problemas Matematicos N5:
        private static void OperacionesRelacionalesLogicasN5(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            OperacionesRelacionalesLogicas.Configurar();
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(OperacionesRelacionalesLogicas.Nivel5[0]);
            try
            {
                if (Console.ReadLine() == OperacionesRelacionalesLogicas.RNivel5[0])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 500;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(OperacionesRelacionalesLogicas.RNivel5[0]);
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(OperacionesRelacionalesLogicas.RNivel5[0]);
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(OperacionesRelacionalesLogicas.RNivel5[0]);
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Correccion Expresiones Matematicas N1:
        private static void CorreccionExpresionesMatematicasN1(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            CorreccionExpresionesMatematicas.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 5);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(CorreccionExpresionesMatematicas.Nivel1[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == CorreccionExpresionesMatematicas.RNivel1[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 100;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(CorreccionExpresionesMatematicas.RNivel1[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(CorreccionExpresionesMatematicas.RNivel1[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(CorreccionExpresionesMatematicas.RNivel1[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Correccion Expresiones Matematicas N2:
        private static void CorreccionExpresionesMatematicasN2(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            CorreccionExpresionesMatematicas.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 5);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(CorreccionExpresionesMatematicas.Nivel2[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == CorreccionExpresionesMatematicas.RNivel2[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 200;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(CorreccionExpresionesMatematicas.RNivel2[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(CorreccionExpresionesMatematicas.RNivel2[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(CorreccionExpresionesMatematicas.RNivel2[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Correccion Expresiones Matematicas N3:
        private static void CorreccionExpresionesMatematicasN3(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            CorreccionExpresionesMatematicas.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 5);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(CorreccionExpresionesMatematicas.Nivel3[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == CorreccionExpresionesMatematicas.RNivel3[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 300;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(CorreccionExpresionesMatematicas.RNivel3[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(CorreccionExpresionesMatematicas.RNivel3[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(CorreccionExpresionesMatematicas.RNivel3[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Correccion Expresiones Matematicas N4:
        private static void CorreccionExpresionesMatematicasN4(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            CorreccionExpresionesMatematicas.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 5);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(CorreccionExpresionesMatematicas.Nivel4[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == CorreccionExpresionesMatematicas.RNivel4[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 400;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(CorreccionExpresionesMatematicas.RNivel4[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(CorreccionExpresionesMatematicas.RNivel4[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(CorreccionExpresionesMatematicas.RNivel4[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Correccion Expresiones Matematicas N5:
        private static void CorreccionExpresionesMatematicasN5(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            CorreccionExpresionesMatematicas.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 5);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(CorreccionExpresionesMatematicas.Nivel5[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == CorreccionExpresionesMatematicas.RNivel5[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 500;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(CorreccionExpresionesMatematicas.RNivel5[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(CorreccionExpresionesMatematicas.RNivel5[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(CorreccionExpresionesMatematicas.RNivel5[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Problemas Matematicos N1:
        private static void ProblemasMatematicosN1(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            ProblemasMatematicos.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 5);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(ProblemasMatematicos.Nivel1[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == ProblemasMatematicos.RNivel1[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 100;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(ProblemasMatematicos.RNivel1[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(ProblemasMatematicos.RNivel1[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(ProblemasMatematicos.RNivel1[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Problemas Matematicos N2:
        private static void ProblemasMatematicosN2(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            ProblemasMatematicos.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 5);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(ProblemasMatematicos.Nivel2[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == ProblemasMatematicos.RNivel2[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 200;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(ProblemasMatematicos.RNivel2[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(ProblemasMatematicos.RNivel2[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(ProblemasMatematicos.RNivel2[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Problemas Matematicos N3:
        private static void ProblemasMatematicosN3(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            ProblemasMatematicos.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 5);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(ProblemasMatematicos.Nivel3[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == ProblemasMatematicos.RNivel3[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 300;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(ProblemasMatematicos.RNivel3[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(ProblemasMatematicos.RNivel3[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(ProblemasMatematicos.RNivel3[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Problemas Matematicos N4:
        private static void ProblemasMatematicosN4(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            ProblemasMatematicos.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 5);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(ProblemasMatematicos.Nivel4[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == ProblemasMatematicos.RNivel4[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 400;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(ProblemasMatematicos.RNivel4[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(ProblemasMatematicos.RNivel4[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(ProblemasMatematicos.RNivel4[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }

        //Problemas Matematicos N5:
        private static void ProblemasMatematicosN5(ref Jugador jugador)
        {
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            ResetTiempo(); //Llama al reset del tiempo.

            ProblemasMatematicos.Configurar();
            Random temporal = new Random();
            int nPregunta = temporal.Next(0, 5);
            Console.WriteLine("*Esta jugando " + jugador.Nombre + "*");
            Console.WriteLine(ProblemasMatematicos.Nivel5[nPregunta]);
            try
            {
                if (Convert.ToDouble(Console.ReadLine()) == ProblemasMatematicos.RNivel5[nPregunta])
                {
                    if (Console.Title != "T I M E ' S   U P")
                    {
                        Console.WriteLine("Correcto");
                        jugador.Punteo += 500;
                        jugador.Invicto = true;

                        timer.Stop();
                        timer.Dispose();
                    }
                    else
                    {
                        Console.WriteLine("Incorrecto");
                        Console.WriteLine("La respuesta correcta era:");
                        Console.WriteLine(ProblemasMatematicos.RNivel5[nPregunta].ToString());
                        jugador.Invicto = false;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                    Console.WriteLine("La respuesta correcta era:");
                    Console.WriteLine(ProblemasMatematicos.RNivel5[nPregunta].ToString());
                    jugador.Invicto = false;

                    timer.Stop();
                    timer.Dispose();
                }
            }
            catch
            {
                Console.WriteLine("Incorrecto");
                Console.WriteLine("La respuesta correcta era:");
                Console.WriteLine(ProblemasMatematicos.RNivel5[nPregunta].ToString());
                jugador.Invicto = false;

                timer.Stop();
                timer.Dispose();
            }
            Console.ReadKey();
        }
        
        //Método que actualiza la tabla lógica según la elección del jugador
        private static void ActualizarTablaLogica(ref Jugador jugador)
        {
            //Guarda en el tablero lógico la posición de la selección.
            switch (tempEleccion2)
            {
                case "100":
                    switch (tempEleccion1)
                    {
                        case "A":
                            tableroVisual[1, 0] = "X";
                            tableroLogico[0, 0] = false;
                            AritmeticaN1(ref jugador);
                            break;
                        case "a":
                            tableroVisual[1, 0] = "X";
                            tableroLogico[0, 0] = false;
                            AritmeticaN1(ref jugador);
                            break;
                        case "B":
                            tableroVisual[1, 1] = "X";
                            tableroLogico[0, 1] = false;
                            OperacionesRelacionalesLogicasN1(ref jugador);
                            break;
                        case "b":
                            tableroVisual[1, 1] = "X";
                            tableroLogico[0, 1] = false;
                            OperacionesRelacionalesLogicasN1(ref jugador);
                            break;
                        case "C":
                            tableroVisual[1, 2] = "X";
                            tableroLogico[0, 2] = false;
                            CorreccionExpresionesMatematicasN1(ref jugador);
                            break;
                        case "c":
                            tableroVisual[1, 2] = "X";
                            tableroLogico[0, 2] = false;
                            CorreccionExpresionesMatematicasN1(ref jugador);
                            break;
                        case "D":
                            tableroVisual[1, 3] = "X";
                            tableroLogico[0, 3] = false;
                            ProblemasMatematicosN1(ref jugador);
                            break;
                        case "d":
                            tableroVisual[1, 3] = "X";
                            tableroLogico[0, 3] = false;
                            ProblemasMatematicosN1(ref jugador);
                            break;
                        default:
                            break;
                    }
                    break;
                case "200":
                    switch (tempEleccion1)
                    {
                        case "A":
                            tableroVisual[2, 0] = "X";
                            tableroLogico[1, 0] = false;
                            AritmeticaN2(ref jugador);
                            break;
                        case "a":
                            tableroVisual[2, 0] = "X";
                            tableroLogico[1, 0] = false;
                            AritmeticaN2(ref jugador);
                            break;
                        case "B":
                            tableroVisual[2, 1] = "X";
                            tableroLogico[1, 1] = false;
                            OperacionesRelacionalesLogicasN2(ref jugador);
                            break;
                        case "b":
                            tableroVisual[2, 1] = "X";
                            tableroLogico[1, 1] = false;
                            OperacionesRelacionalesLogicasN2(ref jugador);
                            break;
                        case "C":
                            tableroVisual[2, 2] = "X";
                            tableroLogico[1, 2] = false;
                            CorreccionExpresionesMatematicasN2(ref jugador);
                            break;
                        case "c":
                            tableroVisual[2, 2] = "X";
                            tableroLogico[1, 2] = false;
                            CorreccionExpresionesMatematicasN2(ref jugador);
                            break;
                        case "D":
                            tableroVisual[2, 3] = "X";
                            tableroLogico[1, 3] = false;
                            ProblemasMatematicosN2(ref jugador);
                            break;
                        case "d":
                            tableroVisual[2, 3] = "X";
                            tableroLogico[1, 3] = false;
                            ProblemasMatematicosN2(ref jugador);
                            break;
                        default:
                            break;
                    }
                    break;
                case "300":
                    switch (tempEleccion1)
                    {
                        case "A":
                            tableroVisual[3, 0] = "X";
                            tableroLogico[2, 0] = false;
                            AritmeticaN3(ref jugador);
                            break;
                        case "a":
                            tableroVisual[3, 0] = "X";
                            tableroLogico[2, 0] = false;
                            AritmeticaN3(ref jugador);
                            break;
                        case "B":
                            tableroVisual[3, 1] = "X";
                            tableroLogico[2, 1] = false;
                            OperacionesRelacionalesLogicasN3(ref jugador);
                            break;
                        case "b":
                            tableroVisual[3, 1] = "X";
                            tableroLogico[2, 1] = false;
                            OperacionesRelacionalesLogicasN3(ref jugador);
                            break;
                        case "C":
                            tableroVisual[3, 2] = "X";
                            tableroLogico[2, 2] = false;
                            CorreccionExpresionesMatematicasN3(ref jugador);
                            break;
                        case "c":
                            tableroVisual[3, 2] = "X";
                            tableroLogico[2, 2] = false;
                            CorreccionExpresionesMatematicasN3(ref jugador);
                            break;
                        case "D":
                            tableroVisual[3, 3] = "X";
                            tableroLogico[2, 3] = false;
                            ProblemasMatematicosN3(ref jugador);
                            break;
                        case "d":
                            tableroVisual[3, 3] = "X";
                            tableroLogico[2, 3] = false;
                            ProblemasMatematicosN3(ref jugador);
                            break;
                        default:
                            break;
                    }
                    break;
                case "400":
                    switch (tempEleccion1)
                    {
                        case "A":
                            tableroVisual[4, 0] = "X";
                            tableroLogico[3, 0] = false;
                            AritmeticaN4(ref jugador);
                            break;
                        case "a":
                            tableroVisual[4, 0] = "X";
                            tableroLogico[3, 0] = false;
                            AritmeticaN4(ref jugador);
                            break;
                        case "B":
                            tableroVisual[4, 1] = "X";
                            tableroLogico[3, 1] = false;
                            OperacionesRelacionalesLogicasN4(ref jugador);
                            break;
                        case "b":
                            tableroVisual[4, 1] = "X";
                            tableroLogico[3, 1] = false;
                            OperacionesRelacionalesLogicasN4(ref jugador);
                            break;
                        case "C":
                            tableroVisual[4, 2] = "X";
                            tableroLogico[3, 2] = false;
                            CorreccionExpresionesMatematicasN4(ref jugador);
                            break;
                        case "c":
                            tableroVisual[4, 2] = "X";
                            tableroLogico[3, 2] = false;
                            CorreccionExpresionesMatematicasN4(ref jugador);
                            break;
                        case "D":
                            tableroVisual[4, 3] = "X";
                            tableroLogico[3, 3] = false;
                            ProblemasMatematicosN4(ref jugador);
                            break;
                        case "d":
                            tableroVisual[4, 3] = "X";
                            tableroLogico[3, 3] = false;
                            ProblemasMatematicosN4(ref jugador);
                            break;
                        default:
                            break;
                    }
                    break;
                case "500":
                    switch (tempEleccion1)
                    {
                        case "A":
                            tableroVisual[5, 0] = "X";
                            tableroLogico[4, 0] = false;
                            AritmeticaN5(ref jugador);
                            break;
                        case "a":
                            tableroVisual[5, 0] = "X";
                            tableroLogico[4, 0] = false;
                            AritmeticaN5(ref jugador);
                            break;
                        case "B":
                            tableroVisual[5, 1] = "X";
                            tableroLogico[4, 1] = false;
                            OperacionesRelacionalesLogicasN5(ref jugador);
                            break;
                        case "b":
                            tableroVisual[5, 1] = "X";
                            tableroLogico[4, 1] = false;
                            OperacionesRelacionalesLogicasN5(ref jugador);
                            break;
                        case "C":
                            tableroVisual[5, 2] = "X";
                            tableroLogico[4, 2] = false;
                            CorreccionExpresionesMatematicasN5(ref jugador);
                            break;
                        case "c":
                            tableroVisual[5, 2] = "X";
                            tableroLogico[4, 2] = false;
                            CorreccionExpresionesMatematicasN5(ref jugador);
                            break;
                        case "D":
                            tableroVisual[5, 3] = "X";
                            tableroLogico[4, 3] = false;
                            ProblemasMatematicosN5(ref jugador);
                            break;
                        case "d":
                            tableroVisual[5, 3] = "X";
                            tableroLogico[4, 3] = false;
                            ProblemasMatematicosN5(ref jugador);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        //Método que actualiza la tabla lógica según la elección del jugador
        private static bool BuscarTablaLogica()
        {
            //Guarda en el tablero lógico la posición de la selección.
            switch (tempEleccion2)
            {
                case "100":
                    switch (tempEleccion1)
                    {
                        case "A":
                            return tableroLogico[0, 0];
                        case "a":
                            return tableroLogico[0, 0];
                        case "B":
                            return tableroLogico[0, 1];
                        case "b":
                            return tableroLogico[0, 1];
                        case "C":
                            return tableroLogico[0, 2];
                        case "c":
                            return tableroLogico[0, 2];
                        case "D":
                            return tableroLogico[0, 3];
                        case "d":
                            return tableroLogico[0, 3];
                        default:
                            return false;
                    }
                case "200":
                    switch (tempEleccion1)
                    {
                        case "A":
                            return tableroLogico[1, 0];
                        case "a":
                            return tableroLogico[1, 0];
                        case "B":
                            return tableroLogico[1, 1];
                        case "b":
                            return tableroLogico[1, 1];
                        case "C":
                            return tableroLogico[1, 2];
                        case "c":
                            return tableroLogico[1, 2];
                        case "D":
                            return tableroLogico[1, 3];
                        case "d":
                            return tableroLogico[1, 3];
                        default:
                            return false;
                    }
                case "300":
                    switch (tempEleccion1)
                    {
                        case "A":
                            return tableroLogico[2, 0];
                        case "a":
                            return tableroLogico[2, 0];
                        case "B":
                            return tableroLogico[2, 1];
                        case "b":
                            return tableroLogico[2, 1];
                        case "C":
                            return tableroLogico[2, 2];
                        case "c":
                            return tableroLogico[2, 2];
                        case "D":
                            return tableroLogico[2, 3];
                        case "d":
                            return tableroLogico[2, 3];
                        default:
                            return false;
                    }
                case "400":
                    switch (tempEleccion1)
                    {
                        case "A":
                            return tableroLogico[3, 0];
                        case "a":
                            return tableroLogico[3, 0];
                        case "B":
                            return tableroLogico[3, 1];
                        case "b":
                            return tableroLogico[3, 1];
                        case "C":
                            return tableroLogico[3, 2];
                        case "c":
                            return tableroLogico[3, 2];
                        case "D":
                            return tableroLogico[3, 3];
                        case "d":
                            return tableroLogico[3, 3];
                        default:
                            return false;
                    }
                case "500":
                    switch (tempEleccion1)
                    {
                        case "A":
                            return tableroLogico[4, 0];
                        case "a":
                            return tableroLogico[4, 0];
                        case "B":
                            return tableroLogico[4, 1];
                        case "b":
                            return tableroLogico[4, 1];
                        case "C":
                            return tableroLogico[4, 2];
                        case "c":
                            return tableroLogico[4, 2];
                        case "D":
                            return tableroLogico[4, 3];
                        case "d":
                            return tableroLogico[4, 3];
                        default:
                            return false;
                    }
                default:
                    return false;
            }
        }

        //Método que guarda la elección del jugador en curso.
        private static void Seleccion(ref Jugador jugador)
        {
            //Registra la elección.
            Console.WriteLine("\n-Ingrese la categoria deseada:");
            VerificarEleccion1();
            Console.WriteLine("-Ingrese el nivel deseado:");
            VerificarEleccion2();

            //Verifica si ya se uso o no la casilla solicitada.
            if (BuscarTablaLogica()) //No se ha usado.
            {
                //Llama al método para actualizar la tabla lógica.
                contadorTurno++;
                ActualizarTablaLogica(ref jugador);
            }
            else //Ya se uso.
            {
                Console.WriteLine("*Sin embargo la casilla solicitada ya fue utilizada, seleccione otra*");
                Seleccion(ref jugador); //Repite el proceso.
            }
        }

        //Imprime la información de la ronda jugada.
        private static void TerminoRonda()
        {
            contadorTurno = 0;
            contadorRonda++;
            Console.Title = "SE TERMINO LA RONDA";
            Console.WriteLine("***************************");
            Console.WriteLine("*¡¡¡SE TERMINO LA RONDA!!!*");
            Console.WriteLine("***************************");

            Console.WriteLine("-Punteo del J1 [" + J1.Nombre + "]: " + J1.Punteo);
            Console.WriteLine("-Punteo del J2 [" + J2.Nombre + "]: " + J2.Punteo);

            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            MostrarTablero(); //Muestra el tablero visual.
        }

        //Método que lleva el control del jugador 1.
        private static void JuegaP1()
        {
            J1.Invicto = true;
            while (J1.Invicto)
            {
                contadorAleatorio += 2;

                Seleccion(ref J1);
                Console.Clear(); //Limpia el texto que está en la consola.

                if (J1.Invicto == false && J2.Invicto == false)
                {
                    TerminoRonda();
                }
                else if (contadorTurno < 5)
                {
                    MostrarTablero(); //Imprime el tablero visual.
                }
                else
                {
                    TerminoRonda();
                }
            }
        }

        //Método que lleva el control del jugador 2.
        private static void JuegaP2()
        {
            J2.Invicto = true;
            while (J2.Invicto)
            {
                contadorAleatorio += 2;

                Seleccion(ref J2);
                Console.Clear(); //Limpia el texto que está en la consola.

                if (J1.Invicto == false && J2.Invicto == false)
                {
                    TerminoRonda();
                }
                else if (contadorTurno < 5)
                {
                    MostrarTablero(); //Imprime el tablero visual.
                }
                else
                {
                    TerminoRonda();
                }
            }
        }

        //Método que lleva el control del tablero lógico.
        private static bool RevisarTablero()
        {
            contadorAleatorio++;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tableroLogico[i, j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Método que verifica si se llego a la ronda 5 para entregar el bono.
        private static void Bono200()
        {
            if (contadorRonda == 5)
            {
                if (J1.Punteo <= J2.Punteo)
                {
                    J1.Punteo += 200;
                    Console.WriteLine("\n\n#############################################################################");
                    Console.WriteLine("¡¡¡SE LE ADJUNTO UN BONO DE 200 PUNTOS AL JUGADOR 1 [" + J1.Nombre + "] POR IR PERDIENDO!!!");
                    Console.WriteLine("#############################################################################\n");
                }
                else
                {
                    J2.Punteo += 200;
                    Console.WriteLine("\n\n###########################################################################################");
                    Console.WriteLine("¡¡¡SE LE ADJUNTO UN BONO DE 200 PUNTOS AL JUGADOR 2 [" + J2.Nombre + "] POR IR PERDIENDO!!!");
                    Console.WriteLine("#######################################################################################\n");
                }
            }
        }

        //Método que verifica si se llego al momento aleatorio para entregar el bono.
        private static bool BonoTriple()
        {
            return (contadorAleatorio >= Aleatorio.Next(15, 50));
        }

        //Método que verifica si el jugador 1 se gana el bono triple.
        private static void BonoTripleJ1()
        {
            if (casillaEspecial)
            {
                if (BonoTriple())
                {
                    Console.Clear();
                    Console.WriteLine("###############################################################");
                    Console.WriteLine("¡¡¡APARECIO LA CASILLA ESPECIAL!!! ¿¿¿DESEA ACEPTARLA??? [Y/N]");
                    Console.WriteLine("###############################################################");

                    string respuesta = Console.ReadLine();
                    if ((respuesta == "Y") || (respuesta == "y"))
                    {
                        Console.WriteLine("\nResponda la siguiente pregunta:");
                        Console.WriteLine(Aritmetica.Nivel5[3]);
                        try
                        {
                            if (Convert.ToDouble(Console.ReadLine()) == Aritmetica.RNivel5[3])
                            {
                                casillaEspecial = false;
                                J1.Punteo *= 3;
                                Console.WriteLine("\n-CORRECTO-");
                                Console.WriteLine("####################################################");
                                Console.WriteLine("¡¡¡SE LE ADJUNTO UN BONO DE TRIPLE PUNTOS TOTALES AL\n JUGADOR 1 [" + J1.Nombre + "] POR ACEPTAR LA CASILLA ESPECIAL!!!");
                                Console.WriteLine("####################################################");

                                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                                Console.ReadKey(); //Espera a que presione cualquier tecla.
                                Console.Clear();
                                MostrarTablero();
                            }
                            else
                            {
                                Console.WriteLine("\n-INCORRECTO-");

                                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                                Console.ReadKey(); //Espera a que presione cualquier tecla.
                                Console.Clear();
                                MostrarTablero();
                            }
                        }
                        catch { }
                    }
                    else
                    {
                        casillaEspecial = true;
                        Console.WriteLine("\nRechazo la casilla especial, presiona cualquier tecla para continuar...");
                        Console.ReadKey(); //Espera a que presione cualquier tecla.
                        Console.Clear();
                        MostrarTablero();
                    }
                }
            }
        }

        //Método que verifica si el jugador 2 se gana el bono triple.
        private static void BonoTripleJ2()
        {
            if (casillaEspecial)
            {
                if (BonoTriple())
                {
                    Console.Clear();
                    Console.WriteLine("###############################################################");
                    Console.WriteLine("¡¡¡APARECIO LA CASILLA ESPECIAL!!! ¿¿¿DESEA ACEPTARLA??? [Y/N]");
                    Console.WriteLine("###############################################################");

                    string respuesta = Console.ReadLine();
                    if ((respuesta == "Y") || (respuesta == "y"))
                    {
                        Console.WriteLine("\nResponda la siguiente pregunta:");
                        Console.WriteLine(Aritmetica.Nivel5[3]);
                        try
                        {
                            if (Convert.ToDouble(Console.ReadLine()) == Aritmetica.RNivel5[3])
                            {
                                casillaEspecial = false;
                                J2.Punteo *= 3;
                                Console.WriteLine("\n-CORRECTO-");
                                Console.WriteLine("####################################################");
                                Console.WriteLine("¡¡¡SE LE ADJUNTO UN BONO DE TRIPLE PUNTOS TOTALES AL\n JUGADOR 2 [" + J2.Nombre + "] POR ACEPTAR LA CASILLA ESPECIAL!!!");
                                Console.WriteLine("####################################################");

                                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                                Console.ReadKey(); //Espera a que presione cualquier tecla.
                                Console.Clear();
                                MostrarTablero();
                            }
                            else
                            {
                                Console.WriteLine("\n-INCORRECTO-");

                                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                                Console.ReadKey(); //Espera a que presione cualquier tecla.
                                Console.Clear();
                                MostrarTablero();
                            }
                        }
                        catch { }
                    }
                    else
                    {
                        casillaEspecial = true;
                        Console.WriteLine("\nRechazo la casilla especial, presiona cualquier tecla para continuar...");
                        Console.ReadKey(); //Espera a que presione cualquier tecla.
                        Console.Clear();
                        MostrarTablero();
                    }
                }
            }
        }

        private static void GameOver()
        {
            //Mensaje de bienvenida.
            Console.Title = "GAME OVER";

            Console.Clear();
            Console.WriteLine("****************");
            Console.WriteLine("¡¡¡GAME OVER!!!*");
            Console.WriteLine("****************");

            if (J1.Punteo > J2.Punteo)
            {
                Console.WriteLine("¡¡¡EL GANADOR ES EL J1 [" + J1.Nombre + "]");
            }
            else
            {
                Console.WriteLine("¡¡¡EL GANADOR ES EL J2 [" + J2.Nombre + "]");
            }

            Console.WriteLine("-Punteo del J1 [" + J1.Nombre + "]: " + J1.Punteo);
            Console.WriteLine("-Punteo del J2 [" + J2.Nombre + "]: " + J2.Punteo);

            Console.WriteLine("Presiona cualquier tecla para salir...");
        }

        //Lógica del juego.
        private static void Juego()
        {
            contadorTurno = 0;
            contadorRonda = 0;
            contadorAleatorio = 0;
            timer = new Timer(1000);

            while (RevisarTablero())
            {
                J1.Invicto = true;
                J2.Invicto = true;

                if (contadorTurno < 5 && RevisarTablero())
                {
                    JuegaP1();
                    BonoTripleJ1();
                    Bono200(); //Siempre revisa si ya se llego a la quinta ronda.
                }
                if (contadorTurno < 5 && RevisarTablero())
                {
                    JuegaP2();
                    BonoTripleJ2();
                    Bono200(); //Siempre revisa si ya se llego a la quinta ronda.
                }
            }

            //Game-Over.
            GameOver();
        }

        //Evento manejador del tiempo.
        private static void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            i--;

            Console.Title = "Time Remaining:  " + i.ToString();
            if (i == 0)
            {
                Console.Title = "T I M E ' S   U P";

                timer.Stop();
                timer.Dispose();
            }
            GC.Collect();
        }

        //Proyecto1_MathJeopardy_1036216.
        static void Main(string[] args)
        {
            Bienvenida(); //Lanza el método de bienvenida.
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); //Espera a que presione cualquier tecla.
            Console.Clear(); //Limpia el texto que está en la consola.

            IniciarTablero(); //Inicia los tableros visual y lógico.
            MostrarTablero(); //Imprime por primera vez el tablero visual.

            Juego(); //Inicia la lógica del juego.
            Console.ReadKey(); //No permite que se cierre la consola.
        }
    }
}
