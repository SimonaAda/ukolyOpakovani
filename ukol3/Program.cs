namespace ukol3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lucistnik archer = new Lucistnik();

            archer.PocetSipu = 10;

            while(archer.PocetSipu >= 1)
            {
            archer.Vystrel();
            }
    
             
        }
    }
}