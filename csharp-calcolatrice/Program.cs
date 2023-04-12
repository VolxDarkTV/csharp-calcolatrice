namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Somma Int = {CalcoliHelper.SommaIntNumeri(5, 6)}");

            Console.WriteLine($"Somma Double = {CalcoliHelper.SommaDoubleNumeri(5.555, 6)}");

            Console.WriteLine($"Diff Int = {CalcoliHelper.DiffIntNum(5, 6)}");

            Console.WriteLine($"Diff Double = {CalcoliHelper.DiffDoubleNum(5.555, 6)}");

            Console.WriteLine($"Molt Int = {CalcoliHelper.MoltIntNum(4, 2)}");

            Console.WriteLine($"Molt Double = {CalcoliHelper.MoltDoubleNum(4, 0.5)}");

            //Valore assoluto Int
            Console.WriteLine($"Assolute Int = {CalcoliHelper.AssoluteIntNum(CalcoliHelper.DiffIntNum(5, 6))}");

            //Valore assoluto Double
            Console.WriteLine($"Assolute Double = {CalcoliHelper.AssoluteDoubleNum(CalcoliHelper.DiffDoubleNum(2.5, 9.2))}");

            //Min Int
            Console.WriteLine($"Min Int = {CalcoliHelper.MinIntNum(2, 2)}");

            //Min Double
            Console.WriteLine($"Min Double = {CalcoliHelper.MinDoubleNum(2.1, 2.3)}");

            //Max Int
            Console.WriteLine($"Max Int = {CalcoliHelper.MaxDoubleNum(2.1, 2.3)}");

            //Max Double
            Console.WriteLine($"Max Double = {CalcoliHelper.MaxDoubleNum(2.7, 6.9)}");

        }
    }
}