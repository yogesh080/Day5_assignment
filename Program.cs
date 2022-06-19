namespace Assingment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int head = 0;
            int tail = 0;
            int numOfTime = 5;
            int[] coin = new int[numOfTime];

            int i = 0;
            while (i < coin.Length)
            {
                Random random = new Random();
                int Flip = random.Next(2);

                if (Flip < 0.5)
                {
                    tail++;
                    Console.WriteLine("No of head:"+ tail);
                    i++;
                }
                else
                {
                    head++;
                    Console.WriteLine("No of tail:" + head);
                    i++;
                }
            }


            int tailPercentage = (tail*100/numOfTime);
            Console.WriteLine("Percentage of head:" + tailPercentage);
            int HeadPercentage = (head*100/numOfTime);
            Console.WriteLine("Percentage of tail:" + HeadPercentage);










        }
    }
}