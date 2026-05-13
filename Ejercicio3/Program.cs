  // puntaje de un videojuego
        int[] puntajes = new int[6];
        int pntmax = 0;
        int pntmin = 0;

        for (int i = 0; i < puntajes.Length; i++)
        {
            try
            {
                Console.Write($"Ingrese el puntaje de la partida {i + 1}: ");
                puntajes[i] = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    pntmax = puntajes[i];
                    pntmin = puntajes[i];
                }
                else
                {
                    if (puntajes[i] > pntmax)
                    {
                        pntmax = puntajes[i];
                    }
                    if (puntajes[i] < pntmin)
                    {
                        pntmin = puntajes[i];
                    }
                }

                // Mostrar cuáles son mayores a 500 dentro del alcance correcto
                if (puntajes[i] > 500)
                {
                    Console.WriteLine($"La partida {i + 1} tuvo un puntaje mayor a 500.");
                }
                else
                {
                    Console.WriteLine($"La partida {i + 1} no tuvo un puntaje mayor a 500.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Por favor, ingrese un número válido para el puntaje.");
                i--; // Se resta 1 para no saltarse el turno de la partida actual
            }
        }

        // Ordenar puntajes de mayor a menor manualmente (Algoritmo de Burbuja)
        for (int j = 0; j < puntajes.Length - 1; j++)
        {
            for (int k = 0; k < puntajes.Length - 1 - j; k++)
            {
                // Si el elemento actual es menor que el siguiente, se intercambian
                if (puntajes[k] < puntajes[k + 1])
                {
                    int temporal = puntajes[k];
                    puntajes[k] = puntajes[k + 1];
                    puntajes[k + 1] = temporal;
                }
            }
        }

        Console.WriteLine("\n--- Resumen ---");
        Console.WriteLine($"El puntaje más alto fue: {pntmax}");
        Console.WriteLine($"El puntaje más bajo fue: {pntmin}");
        
        Console.WriteLine("\nPuntajes ordenados de mayor a menor:");
        foreach (int puntaje in puntajes)
        {
            Console.WriteLine($"Puntaje: {puntaje}");
        }
    
