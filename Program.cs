namespace desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void ConvertirAEnteros()
            {
                try
                {
                    Console.Write("Ingresar el primer número:.... ");
                    string n1 = Console.ReadLine();
                    Console.Write("Ingresar el segundo número:.... ");
                    string n2 = Console.ReadLine();

                    int num1 = int.Parse(n1);
                    int num2 = int.Parse(n2);

                    int resultado = num1 + num2;
                    Console.WriteLine($" EL resultado es: " + resultado);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: introdujó un caracter inválido.");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Error: el valor en blanco.");
                }
                finally
                {
                    Console.WriteLine("Fin del programa. :)) ");
                }
            }
            ConvertirAEnteros();
        }
    }
}