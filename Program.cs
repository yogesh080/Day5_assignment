namespace Assingment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for even or odd");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = num%2;

            if(result == 0)
            {
                Console.WriteLine("number is even ");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}