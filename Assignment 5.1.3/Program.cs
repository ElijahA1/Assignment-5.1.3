namespace Assignment_5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            int[] array1 = { 1, 2, 3, 1 };

            Console.WriteLine(containsRepeatValues(array));
            Console.WriteLine(containsRepeatValues(array1));
        }

        static bool containsRepeatValues(int[] array) 
        {
            HashSet<int> set = new();

            foreach (int i in array) 
            {
                if (!set.Add(i)) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}
