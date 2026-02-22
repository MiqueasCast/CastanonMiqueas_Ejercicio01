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

else
{
    switch (inputUser)
    {
        case 1:
            if (oxygenSaturation < 90 || systolicPressure < 90 || systolicPressure > 140)
            {
                Console.WriteLine("Prioridad alta");
                Console.WriteLine("Acción sugerida: Ranimación inmediata");
            }
            else
            {
                if (temperature >= 38.5 || temperature < 35)
                {
                    Console.WriteLine("Prioridad alta");
                    Console.WriteLine("Acción sugerida: Evaluación médica urgente");
                }
                else if (painLevel >= 5)
                {
                    Console.WriteLine("Prioridad media");
                    Console.WriteLine("Acción sugerida: Evaluación médica en breve");
                }
                else
                {
                    Console.WriteLine("Prioridad baja");
                    Console.WriteLine("Acción sugerida: Evaluación médica programada");
                }
            }
            break;
        case 2:
            if (oxygenSaturation > 90 && oxygenSaturation <= 100 && systolicPressure >= 90 && systolicPressure <= 120 && temperature >= 35.5 && temperature < 38)
            {
                Console.WriteLine("Oxigeno y presion dentro del rango normal");
                Console.WriteLine("Acción sugerida: Consulta general para chequo de salud");
            }
            else if (painLevel > 5)
            {
                Console.WriteLine("Nivel de dolor medio");
                Console.WriteLine("Acción sugerida: Consulta médica para evaluación del dolor");
            }
            else
            {
                Console.WriteLine("pasar a emergencia");
            }

            break;
        case 3:
            if (age < 12 && temperature >= 38.5)
            {
                Console.WriteLine("Prioridad alta");
                Console.WriteLine("Acción sugerida: Evaluación médica urgente");
            }
            else if (age < 12 && age >= 37.5 && temperature < 38.5)
            {
                Console.WriteLine("Prioridad media");
                Console.WriteLine("Acción sugerida: Evaluación médica en breve");
            }
            else
            {
                Console.WriteLine("Prioridad baja");
                Console.WriteLine("Acción sugerida: Evaluación médica programada");
            }
            break;

        case 4:
            if (age > 12 && painLevel > 6)
            {
                Console.WriteLine("Prioridad alta");
                Console.WriteLine("Acción sugerida:atencion traumatologica urgente ");
            }
            else if (age < 12 && painLevel < 0)
            {
                Console.WriteLine("Prioridad Alta");
                Console.WriteLine("Acción sugerida:atencion traumatologica urgente y llamar a un pediatra para revision general");
            }
            else
            {
                Console.WriteLine("Prioridad baja");
                Console.WriteLine("Acción sugerida: Evaluación médica programada");
            }
            break;
        default:
            Console.WriteLine("Opción invalida");
            break;
    }
}