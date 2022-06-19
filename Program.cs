namespace Assingment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a (int) Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a,b;
            int flag = 0;
            int count = 0;

            for (a = 2; a <= num; a++)
            {
                if(num % a == 0)
                {
                     count = 0;
                     for(b = 1; b <= a; b++)
                    {
                        if (a%b == 0)
                            count++;    
                    }
                    if(count == 2)
                    {
                        flag = 1;
                        Console.WriteLine("prime factor of number is :  " + a);
                    }
                }

            }
            if(flag == 0)
                Console.WriteLine("there is no Prime factor");
            
        }
    }
}