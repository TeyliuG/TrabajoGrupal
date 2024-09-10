﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoGrupal
{
    internal class RPG
    {
        private Jugador jugador;

        public void Execute()
        {
            CreatePlayerMenu();
            MainGameLoop();
        }

        private void CreatePlayerMenu()
        {
            string name;
            Console.WriteLine("Introduce tu nombre:");
            name = Console.ReadLine();
            int level = 0;
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce el nivel (número entero positivo):");
                level = int.Parse(Console.ReadLine());

                if (level > 0)
                {
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine("El nivel debe ser un número entero positivo. Intenta de nuevo.");
                }
            }
            jugador = new Jugador(name, level);
            Console.WriteLine($"Se creó el jugador:");
            Console.WriteLine(jugador.GetData());
        }
        private void CreateNPCMenu()
        {
            Console.WriteLine("Introduce el nombre del NPC:");
            string name = Console.ReadLine();

            int level = 0;
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce el nivel del NPC (número entero positivo):");
                string input = Console.ReadLine();

                if (int.TryParse(input, out level) && level > 0)
                {
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine("El nivel debe ser un número entero positivo. Intenta de nuevo.");
                }
            }

            NPC.AddNPC(name, level); 
            Console.WriteLine("Se creó el NPC: " + name);
        }
        private void MainGameLoop()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMenú de Opciones:");
                Console.WriteLine("1. Crear Jugador");
                Console.WriteLine("2. Mostrar Jugador");
                Console.WriteLine("3. Crear NPC");
                Console.WriteLine("4. Salir");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        CreatePlayerMenu();
                        break;
                    case "2":
                        if (jugador != null)
                        {
                            Console.WriteLine(jugador.GetData());
                        }
                        else
                        {
                            Console.WriteLine("No hay jugador creado.");
                        }
                        break;
                    case "3":
                        CreateNPCMenu();
                        break;                       
                    case "4":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                    
                }
            }
        }
    }







































































































}

