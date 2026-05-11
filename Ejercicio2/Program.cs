// Ventas semanales de una tienda//

double[] ventasSemanales = new double[7];
string[] diasSeman = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
double suma;
double minimo;
try 
{
for (int i = 0; i < ventasSemanales.Length; i++)
{
    Console.Write($"Ingrese las ventas del {diasSeman[i]}: ");
    ventasSemanales[i] = Convert.ToDouble(Console.ReadLine());
}
}
catch (FormatException)
{
    Console.WriteLine("Error: Por favor, ingrese un número válido para las ventas.");
    return;
}
minimo = ventasSemanales[0];
for (int i = 1; i < ventasSemanales.Length; i++)
{
    if (ventasSemanales[i] < minimo)
    {
        minimo = ventasSemanales[i];
    }
}

for (int i = 0; i < ventasSemanales.Length; i++)
{
    Console.WriteLine($"Ventas del {diasSeman[i]}: {ventasSemanales[i]:C}");
}
suma = 0;
for (int i = 0; i < ventasSemanales.Length; i++)
{
    suma += ventasSemanales[i];
}
Console.WriteLine($"Total de ventas semanales: {suma:C}");
//registrar si cada dia la venta fue mayor a 150//
for (int i = 0; i < ventasSemanales.Length; i++)
{
    if (ventasSemanales[i] > 150)
    {
        Console.WriteLine($"El {diasSeman[i]} tuvo una venta mayor a $150.");
    }
    else
    {
        Console.WriteLine($"El {diasSeman[i]} no tuvo una venta mayor a $150.");
    }
}