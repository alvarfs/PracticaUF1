internal class Program
{
    private static void Main(string[] args)
    {
        int numUser;
        
        Console.Write("Escribe un numero: ");
        numUser = Convert.ToInt32(System.Console.ReadLine());

        if (numUser > 50){
            Console.WriteLine("Tu numero es mayor a 50!");
        }
        else if (numUser < 50){
            Console.WriteLine("Tu numero es menor a 50!");
        }
        else{
            Console.WriteLine("Tu numero es 50!");
        }

        Console.WriteLine("PULSA ENTER PARA FINALIZAR...");
        System.Console.ReadLine();
    }
}