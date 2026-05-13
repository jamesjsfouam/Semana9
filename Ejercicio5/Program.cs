// Solicitar notas de 8 estudiantes, mostrar las aprobadas y contar cuantos estudiantes aprobaron y desaprobaron, y calcular el promedio de las notas aprobadas y desaprobadas.
int[] notas = new int[8];
int aprobados = 0;
int desaprobados = 0;
int sumaAprobados = 0;
int sumaDesaprobados = 0;

try
{
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine("Ingrese la nota del estudiante " + (i + 1) + ":");
        notas[i] = int.Parse(Console.ReadLine());

        if (notas[i] >= 60 && notas[i] <= 100)
        {
            Console.WriteLine("El estudiante " + (i + 1) + " aprobó con la nota: " + notas[i]);
            aprobados++;
            sumaAprobados += notas[i];
        }
        else if (notas[i] >= 0 && notas[i] < 60)
        {
            desaprobados++;
            sumaDesaprobados += notas[i];
        }
        else
        {
            Console.WriteLine("Error: Por favor ingrese una nota válida (0-100).");
            return;
        }
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor ingrese un número válido.");
    return;
}

for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] >= 60)
    {
        Console.WriteLine("El estudiante " + (i + 1) + " Aprobo con " + notas[i]);
    }
}
Console.WriteLine("Cantidad de estudiantes desaprobados: " + desaprobados);
Console.WriteLine("Promedio de notas: " + ((sumaAprobados + sumaDesaprobados) / 8.0));
