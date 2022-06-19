namespace Assingment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dividend");
            int dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the divisor");
            int divisor = int.Parse(Console.ReadLine());


            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient is: " + quotient);
            Console.WriteLine("Remainder is: " + remainder);





        }
    }
}