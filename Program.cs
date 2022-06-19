namespace Assingment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 10;
            Console.WriteLine("Before swap number 1 = "+num1+" number 2 = "+num2);
            num1=num1*num2;      
            num2=num1/num2;      
            num1=num1/num2;    
            Console.Write("After swap number 1 = "+num1+" number 2 = "+num2);


        }
    }
}
