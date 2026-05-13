double [,] matriz = new double [3,3];
Console.WriteLine("Matrices");
Console.WriteLine("Ingresa las temperaturas de la matriz");
int contador = 0;
try
{
for(int r = 0; r < 3; r++)
{
    for(int c = 0; c < 3; c++)
{ 
Console.WriteLine($"Temperatura #{++contador}:");
matriz[r, c] = Convert.ToDouble(Console.ReadLine());
}
}
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("vuelve a ingresar la temperatura, solo se permiten numeros");
    Console.ResetColor();
    return;


}
Console.Clear();
Console.WriteLine("Temperaturas ingresadas:");
for(int f=0 ; f < 3; f++)
{
    for(int c = 0; c < 3; c++)
    {
        if(matriz[f,c] <=35) Console.ForegroundColor = ConsoleColor.Green;
        else if(matriz[f,c] >= 35 && matriz[f,c] < 40) Console.ForegroundColor = ConsoleColor.Yellow;
        else Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{matriz[f,c]} ");
        Console.ResetColor();
    }
    Console.WriteLine();
}