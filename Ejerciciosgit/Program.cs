namespace Ejerciciosgit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10, num2 = 20, resultado;
            int opcion;

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");

            Console.Write("Escoge una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = Suma( num1, num2);
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
            }

        }

        static double Suma(double num1, double num2)
        {

            double resultado = num1 + num2;

            return resultado;
        }

        static double Resta(double num1, double num2)
        {

            double resultado = num1 - num2;

            return resultado;
        }

        static double Multiplicacion(double num1, double num2)
        {

            double resultado = num1 * num2;

            return resultado;
        }

    }
}
