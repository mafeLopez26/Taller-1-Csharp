2//namespace mensaje
{
    internal class program
{
    static void main()
    {

        Console.WriteLine("ingrese 3 números");
        Console.WriteLine("Ingrese el número 1");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el número 2");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el numero 3");
        double num3 = Convert.ToDouble(Console.ReadLine());
        double mayor;
        double menor;
        if (num1 < num2 && num1 < num3)
        {
            mayor = num1;
        }
        else if (num2 < num1 && num2 < num3)
        {
            mayor = num2;
        }
        else
        {
            mayor = num3;
        }
        if (num1 > num2 && num1 > num3)
        {
            menor = num1;
        }
        else if (num2 > num1 && num2 > num3)
        {
            menor = num2;
        }
        else
        {
            menor = num3;
        }
        Console.WriteLine("El número mayor es:" + mayor);
        Console.WriteLine("El número menor es:" + menor);
    }
}
}