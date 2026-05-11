// temperatura de la semana
int[] temperaturas = new int[7];
string[] dias = new string[7] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
int promedio;

int maxima = 0; 
int minima = 0; 

for (int i = 0; i < 7; i++)
{
    Console.WriteLine("Ingrese la temperatura del dia " + dias[i] + ": ");
    temperaturas[i] = int.Parse(Console.ReadLine());

    // Si es el primer día, inicializamos maxima y minima con este valor
    if (i == 0)
    {
        maxima = temperaturas[i];
        minima = temperaturas[i];
    }
    else
    {
        // Para los días siguientes, comparamos normalmente
        if (temperaturas[i] > maxima)
        {
            maxima = temperaturas[i];
        }

        if (temperaturas[i] < minima)
        {
            minima = temperaturas[i];
        }
    }
}

for (int i = 0; i < 7; i++)
{
    Console.WriteLine("la temperatura de el dia " + dias[i] + " es: " + temperaturas[i]);
}

promedio = temperaturas.Sum() / 7;
Console.WriteLine("El promedio de las temperaturas es: " + promedio);
Console.ForegroundColor = ConsoleColor.Green; // Cambia el color de la consola a verde para resaltar la temperatura máxima
Console.WriteLine("La temperatura máxima fue: " + maxima);
Console.ResetColor(); 
Console.ForegroundColor = ConsoleColor.Red; // Cambia el color de la consola a rojo para resaltar la temperatura mínima
Console.WriteLine("La temperatura mínima fue: " + minima);
Console.ResetColor(); 