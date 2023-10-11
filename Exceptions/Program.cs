// See https://aka.ms/new-console-template for more information



 public class program
{
    static void Main(string[] args)
    {
        string s = null;
        MyMethod(s);

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
    }
}       
 
