namespace mensaje
{
    internal class program
    {
        static void main()
        {
            EJERCICIO 5
            Console.Write("Ingrese la cantidad de números primos que desea generar: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            int numero = 2;
            Console.WriteLine($"Los primeros {cantidad} números primos son:");
            while (contador < cantidad)
            {
                bool esPrimo = true;
                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if (esPrimo)
                {
                    Console.WriteLine(numero);
                    contador++;
                }
                numero++;
            }
        }
    }
}
