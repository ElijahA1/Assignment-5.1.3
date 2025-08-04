namespace Assignment_5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };

            Console.WriteLine(containsRepeatValues(array));
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
