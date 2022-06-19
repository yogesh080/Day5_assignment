namespace Assingment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputstring;
            int i, vowels, consonants;

            inputstring = "hello world";
            vowels = 0;
            consonants = 0;
            for (i = 0; i < inputstring.Length; i++)
            {
                if (inputstring[i] == 'a' || inputstring[i] == 'e' || inputstring[i] == 'i' || inputstring[i] == 'o' || inputstring[i] == 'u' || inputstring[i] == 'A' ||
                    inputstring[i] == 'E' || inputstring[i] == 'I' || inputstring[i] == 'O' || inputstring[i] == 'U')
                {
                    vowels++;
                }
                else if ((inputstring[i] >= 'a' && inputstring[i] <= 'z') ||
                         (inputstring[i] >= 'A' && inputstring[i] <= 'Z'))
                {
                    consonants++;
                }
            }

            Console.WriteLine("Number of vowel = " + vowels);
            Console.WriteLine("Number of consonant = " + consonants);
        



        }
    }
}