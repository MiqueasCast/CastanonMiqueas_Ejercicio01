using System.Drawing;

Console.WriteLine("Menú");
Console.WriteLine("1. Emergencia");
Console.WriteLine("2. Consulta");
Console.WriteLine("3. Pediatría");
Console.WriteLine("4. Trumatología");

int inputUser = int.Parse(Console.ReadLine());

Console.WriteLine("Edad:");
double age = int.Parse(Console.ReadLine());
Console.WriteLine("Temperatura:");
double temperature = double.Parse(Console.ReadLine());
Console.WriteLine("Saturación de oxígeno:");
double oxygenSaturation = int.Parse(Console.ReadLine());
Console.WriteLine("Nivel de dolor (0-10):");
int painLevel = int.Parse(Console.ReadLine());
Console.WriteLine("Presión sistólica:");
double systolicPressure = int.Parse(Console.ReadLine());
if (age <= 0 || age > 120 && temperature < 30 || temperature > 45 && oxygenSaturation < 0 || oxygenSaturation > 100 && painLevel < 1 || painLevel > 10 && systolicPressure < 50 || systolicPressure > 250)
{
    Console.WriteLine("Error: Edad fuera de rango.");
}

