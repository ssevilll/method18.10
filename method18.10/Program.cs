namespace method18._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            foreach (int i in SquareOfElements(nums))
            {
                Console.WriteLine(i);
            }
        }

        public static int[] SquareOfElements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
            }
            return arr;
        }
    }
}
