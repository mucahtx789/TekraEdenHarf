namespace TekraEdenHarf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir kelime: ");

            string word = Console.ReadLine();

            string maxLetter = word[0].ToString();
            int max = 0;
            int number = 0;


            for (int i = 0; i < word.Length; i++)
            {
                for (int b = 0; b < word.Length; b++)
                {
                    if (word[i] == word[b])
                    {
                        number++;
                    }
                }
                if (number > max) { 
                    max = number;
                maxLetter=word[i].ToString();
                }
                number = 0;

            }
            Console.WriteLine("tekrar eden harf :"+maxLetter+" tekrar sayısı :"+max );
        }
    }
}
