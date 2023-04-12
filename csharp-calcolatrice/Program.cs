namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Somma Int = {CalcoliHelper.SommaNumeri(5, 6)}");

            Console.WriteLine($"Somma Double = {CalcoliHelper.SommaNumeri(5.555, 6)}");

            Console.WriteLine($"Diff Int = {CalcoliHelper.DiffNum(5, 6)}");

            Console.WriteLine($"Diff Double = {CalcoliHelper.DiffNum(5.555, 6)}");

            Console.WriteLine($"Molt Int = {CalcoliHelper.MoltNum(4, 2)}");

            Console.WriteLine($"Molt Double = {CalcoliHelper.MoltNum(4, 0.5)}");

            //Valore assoluto Int
            Console.WriteLine($"Assolute Int = {CalcoliHelper.AssoluteNum(CalcoliHelper.DiffNum(5, 6))}");

            //Valore assoluto Double
            Console.WriteLine($"Assolute Double = {CalcoliHelper.AssoluteNum(CalcoliHelper.DiffNum(2.5, 9.2))}");

            //Min Int
            Console.WriteLine($"Min Int = {CalcoliHelper.MinNum(2, 2)}");

            //Min Double
            Console.WriteLine($"Min Double = {CalcoliHelper.MinNum(2.1, 2.3)}");

            //Max Int
            Console.WriteLine($"Max Int = {CalcoliHelper.MaxNum(2.1, 2.3)}");

            //Max Double
            Console.WriteLine($"Max Double = {CalcoliHelper.MaxNum(2.7, 6.9)}");

            Console.WriteLine(CalcoliHelper.ElevateNum(2,30));

            

        }
    }
}