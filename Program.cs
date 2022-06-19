namespace Assingment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            while(N <= 10)
            {
                var Power = Math.Pow(2, N);
                N++;
                Console.WriteLine(Power);
            }
        }
    }
}