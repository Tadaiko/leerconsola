using System;

//Console.Write("Ingrese su nombre: ");
//string? nombre = Console.ReadLine();

//Console.Write("Ingrese Nota 1: ");
//string? entrada1 = Console.ReadLine();
//double.TryParse(entrada1, out double nota1);

//Console.Write("Ingrese Nota 2: ");
//string? entrada2 = Console.ReadLine();
//double.TryParse(entrada2, out double nota2);

//Console.Write("Ingrese Nota 3: ");
//string? entrada3 = Console.ReadLine();
//double.TryParse(entrada3, out double nota3);

// Cálculo del promedio
//double promedio = (nota1 + nota2 + nota3) / 3;

// Lógica de aprobación (típica en Chile)
//string resultado = (promedio >= 4.0) ? "Aprobado" : "Reprobado";

// Console.WriteLine("\n--- Resultados ---");
//Console.WriteLine($"Estudiante: {nombre}");
//Console.WriteLine($"Promedio: {promedio:F1}"); // F1 muestra un decimal
//Console.WriteLine($"Estado: {resultado}");

//Console.Write("Ingrese su nombre: ");
//string? nombre = Console.ReadLine();

//Console.Write("Ingrese su edad: ");
//string? Edad = Console.ReadLine();
//int.TryParse(Edad, out int edad); 

//Console.Write("Ingrese el precio: ");
//string? Precio = Console.ReadLine();
//double.TryParse(Precio, out double precio);

//Console.WriteLine($"\nHola {nombre}, tienes {edad} años y el precio es {precio:C}");

//Console.ReadKey();

Console.Write("Ingrese la descripción de lo que va a sumar: ");
string? descripcion = Console.ReadLine();

double sumaTotal = 0;
double numeroIngresado = 0;

while (true) 
{
    Console.Write("Ingrese un número (-99 para finalizar): ");
    string? entrada = Console.ReadLine();
    
    if (double.TryParse(entrada, out numeroIngresado))
    {
        if (numeroIngresado == -99)
        {
            break;
        }

        sumaTotal += numeroIngresado;
    }
    else
    {
        Console.WriteLine("Por favor, ingrese un número válido.");
    }
}

Console.WriteLine("\n--- Reporte Final ---");
Console.WriteLine($"Descripción: {descripcion}");
Console.WriteLine($"Resultado total de la suma: {sumaTotal}");

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();