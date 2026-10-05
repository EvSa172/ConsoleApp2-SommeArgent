namespace ConsoleApp2_SommeArgent
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const decimal Interet = 0.013m;
            decimal compte = 1200;

            Console.WriteLine("Somme d'argent que vous aimerait atteindre ");
            decimal sommeArgent = Convert.ToDecimal(Console.ReadLine());

            int annees = 0;

            while (compte < sommeArgent)
            {
                compte += compte * Interet;
                annees++;
            }

            Console.WriteLine($"Il faut faudra {annees} ans pour atteindre cette somme");
        }
    }
}
