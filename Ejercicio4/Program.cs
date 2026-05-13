//Inventario de una librería indicar cateoria con mas ventas y promedio//
int[] inventario = new int[5];
string[] libros = { "Fantasia", "Ciencia ficción", "Misterio", "Romance", "Suspenso" };
try
{
    for (int i = 0; i < inventario.Length; i++)
    {
        Console.Write($"Ingrese la cantidad de libros de {libros[i]}: ");
        inventario[i] = int.Parse(Console.ReadLine());
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido para la cantidad de libros.");
    return;
}
Console.WriteLine("Inventario de libros:");
for (int i = 0; i < inventario.Length; i++)
{
    Console.WriteLine($"Se vendieron {inventario[i]} libros de {libros[i]}.");
}

int maxInventario = inventario[0];
string categoriaMax = libros[0];

for (int i = 1; i < inventario.Length; i++)
{
    if (inventario[i] > maxInventario)
    {
        maxInventario = inventario[i];
        categoriaMax = libros[i];
    }
}
int sumaInventario = 0;
for (int i = 0; i < inventario.Length; i++)
{
    sumaInventario += inventario[i];
}
double promedioInventario = (double)sumaInventario / inventario.Length;
Console.WriteLine($"La categoría con más ventas es: {categoriaMax} con {maxInventario} libros vendidos.");
Console.WriteLine($"El promedio de libros vendidos es: {promedioInventario:F2}.");

