namespace ukol2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik hvězdiček chcete zobrazit?");

            int pocetHvezd = int.Parse(Console.ReadLine());
            for (int i = 0; i < pocetHvezd; i++)
            {
                Console.Write("*");
            }
        }
    }
}