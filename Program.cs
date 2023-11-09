internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Escribe un numero: ");
        int numUser = Convert.ToInt32(System.Console.ReadLine());

        if (numUser > 50){
            Console.WriteLine("Tu numero es mayor a 50!");
        }

        Console.WriteLine("Fin del programa");
    }
}