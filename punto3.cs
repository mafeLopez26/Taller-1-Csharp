namespace mensaje
{
    internal class program
    {
        static void main()
        {
            EJERCICIO 3
Console.WriteLine("Ingrese el número de empleados:");
            int numEmp = int.Parse(Console.ReadLine());
            double totalSueldosNetos = 0;
            double totalAFP = 0;
            double totalSeguroSocial = 0;
            for (int i = 1; i <= numEmp; i++)
            {
                Console.WriteLine($"Ingrese el sueldo base del empleado {i}:");
                double sueldoBase = double.Parse(Console.ReadLine());
                double renta = sueldoBase * 0.10;
                double afp = sueldoBase * 0.05;
                double seguroSocial = sueldoBase * 0.04;
                double sueldoNeto = sueldoBase - (renta + afp + seguroSocial);
                totalSueldosNetos += sueldoNeto;
                totalAFP += afp;
                totalSeguroSocial += seguroSocial;
            }
            Console.WriteLine("Reporte contable:");
            Console.WriteLine($"Total a pagar en sueldos netos: {totalSueldosNetos}");
            Console.WriteLine($"Total retenido en AFP: {totalAFP}");
            Console.WriteLine($"Total retenido en Seguro Social: {totalSeguroSocial}");
            Console.ReadLine();
        }
    }
}



