using System.Threading.Channels;

namespace finding_number_ranges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 4, 5 };
            int range = 4;
            int start = 1;
            FindRange(nums, range,start );
        }


         static void FindRange(int[] nums, int range , int start)
        {
            //int n = nums.Length+ 1;
            //int totalsum = n * (n + 1) / 2;
            //int arraysum = 0;

            //foreach (int i in nums) 
            //{
            //    arraysum += i;
            //}
            //return  arraysum - totalsum;
            Dictionary<int, bool> numberMap = new Dictionary<int, bool>();

            foreach (int num in nums)
            {
                if (!numberMap.ContainsKey(num))
                {
                    numberMap[num] = true;
                }
            }

            // Step 2: Find missing numbers in the range
            Console.WriteLine("Missing numbers:");
            for (int i = start; i <= range; i++)
            {
                if (!numberMap.ContainsKey(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }



}

