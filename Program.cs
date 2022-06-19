namespace Assingment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for leap year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year%4==0)
            {
                Console.WriteLine("Is leap year");
            }
            else
            {
                Console.WriteLine("Is not leap year");
            }
        }
    }
}