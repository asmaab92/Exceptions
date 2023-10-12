// See https://aka.ms/new-console-template for more information



using Exceptions;

public class program
{
    static void Main(string[] args)
    {
        string s = null;
        MyMethod(s);
        string path = null;
        ReadingFile(path);

       

        static List<int> MyMethod(string s)
        {
            s = "23,34,12,9,67";


            string[] numberString = s.Split(',');
            int[] numbers = new int[numberString.Length];

            for (int i = 0; i < numberString.Length; i++)
            {
                try
                {
                    numbers[i] = int.Parse(numberString[i]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entry discarded");
                }
            }

            List<int> nums = new List<int>(numbers)
                .OrderByDescending( numbers => numbers)
                .ToList();

            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }

            return nums;
        }

         static WordsDTO ReadingFile(string path)
        {
            path = "C:\\Users\\deltagaren\\Desktop\\Flowers.txt";
            WordsDTO dto = new WordsDTO();
            
            try 
            {
                string content = File.ReadAllText(path);
                string[] text = content.Split(",");

                dto.Text = text;
                dto.Result = true;
                dto.Message = "Success";
                Console.WriteLine(text);
            }

            catch  (FileNotFoundException)
            {
                dto.Text = null;
                dto.Result= false;
                dto.Message = "File not found";
            }

            return dto;

        }
    }
}       
 
