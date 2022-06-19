namespace Assingment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("Number of input: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <= num; i++)
            {
                Console.WriteLine("1/{0} + ",i);
                //s+=1/(float)i;
                Console.WriteLine("\nThe nth  Harmonic Number : 1/{0} ", num);
            }
            
        }
    }
}