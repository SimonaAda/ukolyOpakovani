namespace ukol1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte první číslo.");

           
            int cislo1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte druhé číslo.");

            int cislo2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Výsledek sčítaní je {cislo1 + cislo2}");
            

        }
    }
}