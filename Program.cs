namespace Assingment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            
         

            Console.Write(" 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" 2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greater ");
                }
                else
                {
                    Console.Write("The 3rd Number is the greater");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greater");
            else
                Console.Write("The 3rd Number is the greater");

        }
    }
}
