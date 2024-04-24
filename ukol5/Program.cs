namespace ukol5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hádej číslo, hadači.");

            int cislo;

            while (true)
            {
                cislo = int.Parse(Console.ReadLine());

                if (cislo == 5)
                {
                    Console.WriteLine("To je správně.");
                    return;
                }
                else if (cislo < 5)
                {
                    Console.WriteLine("Číslo je větší, hádej znova.");
                }
                else
                {
                    Console.WriteLine("Číslo je menší, hádej znova.");
                }
        }   }
    }
}