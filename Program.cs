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
                    Console.WriteLine(number)
                    numbers.Add(number);
                }
            }

            int sum = numbers.Sum();
            Console.WriteLine($"The sum of all numbers: {sum}.\n")

            double average = numbers.Average();
            Console.WriteLine($"The average of all numbers: {average}.\n")

            numbers.Sort();
            Console.WriteLine(numbers);

            StreamWriter sorted = new StreamWriter("SortedNumber.txt");

            foreach (int number in numbers)
            {
                sorted.WriteLine(number);
            }
            sorted.Close();

            StreamWriter sumAndAverage = new StreamWriter("NumberSummery.txt");

            sumAndAverage.WriteLine(sum, average);

        }
                
    }
}