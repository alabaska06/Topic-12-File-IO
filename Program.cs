using System.Text;

namespace Topic_12_File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            StreamWriter writer = new StreamWriter("capitals.txt");

            List<string> words = new List<string>();

            foreach (string line in File.ReadLines(@"test.txt", Encoding.UTF8))
            {               
                words.Add(line.ToUpper());
            }
            //do this
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            //or this to diplay
            Console.WriteLine(string.Join("\n", words));

            foreach (string word in words)
            {
                writer.WriteLine(word);
            }
            writer.Close();
            */

            List<int> numbers = new List<int>();

            foreach (string line in File.ReadLines(@"numbers.txt", Encoding.UTF8))
            {
                if (int.TryParse(line, out int number))
                {
                    Console.WriteLine(number);
                    numbers.Add(number);
                }
            }


        }
                
    }
}