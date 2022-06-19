namespace Assingment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 10;
            Console.WriteLine("Before swap a= "+num1+" b= "+num2);
            num1=num1*num2;      
            num2=num1/num2;      
            num1=num1/num2;    
            Console.Write("After swap a= "+num1+" b= "+num2);


        }
    }
}
