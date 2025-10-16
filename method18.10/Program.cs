namespace method18._10
{
    internal class Program
    {
        static void Main(string[] args)
        #region Task-1
        //{
        //    int[] nums = { 1, 2, 3, 4, 5 };
        //    foreach (int i in SquareOfElements(nums))
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //public static int[] SquareOfElements(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = arr[i] * arr[i];
        //    }
        //    return arr;
        //} 
        #endregion
        #region Task-2
        //{
        //    int[] nums = { 1, 2, 3, 4, 5 };
        //    foreach (int num in RemoveTheSmallest(nums))
        //    {
        //        Console.WriteLine(num);
        //    }
        //}

        //public static int[] RemoveTheSmallest (int[] arr)
        //{
        //    int min = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //    }

        //    int[] newArr = new int[arr.Length - 1];
        //    int j = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] != min)
        //        {
        //            newArr[j] = arr[i];
        //            j++;
        //        }
        //    }

        //    return newArr;

        //} 
        #endregion
        #region Task-3
        //{
        //    string sentence="kertenkele";
        //    if (IsUniqe(sentence) != '0')
        //    {
        //        Console.WriteLine(IsUniqe(sentence));
        //    }
        //    else
        //    {
        //        Console.WriteLine("Bele bir simvol yoxdur");
        //    }
        //}

        //public static char IsUniqe (string word) {
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        bool isUniqe = true;
        //        for (int j = 0; j < word.Length; j++)
        //        {
        //            if ((word[i] == word[j]) && (i != j))
        //            {
        //                isUniqe= false;
        //                break;
        //            }
        //        }
        //        if (isUniqe)
        //        {
        //            return word[i];
        //        }
        //    }
        //    return '0';
        //} 
        #endregion
        #region Task-4
        //{
        //    int a = 7;
        //    if (IsPrime(a))
        //    {
        //        Console.WriteLine("sadedir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("sade deyil");
        //    }
        //}
        //public static bool IsPrime(int number)
        //{
        //    if (number <= 1) return false;
        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0) return false;
        //    }
        //    return true;
        //} 
        #endregion
        #region Task-5
        //{ 
        //    int N= 100;
        //    int M= 200;
        //    Polindrome(N, M);
        //}
        //public static void Polindrome(int a, int b)
        //{
        //    for (int i=a; i<=b; i++)
        //    {
        //        string str = i.ToString();
        //        int count = 0;
        //        for (int j = 0; j < str.Length / 2; j++)
        //        {
        //            if (str[j] == str[str.Length - 1 - j])
        //            {
        //                count++;
        //            }
        //        }
        //        if (count == str.Length / 2)
        //        {
        //            Console.WriteLine(str);
        //        }
        //    }
        //} 
        #endregion
        #region Task-6
        //{ 
        //    string word = "abccccdd";
        //    MostUsedCharacter(word);
        //}
        //public static void MostUsedCharacter(string s)
        //{
        //    char[] chars = s.ToCharArray();
        //    Array.Sort(chars);
        //    int tempCount = 1;
        //    int maxCount = tempCount;
        //    char mostUsedChar = chars[0];
        //    char temp = chars[0];
        //    for (int i = 1; i < chars.Length; i++)
        //    {
        //        if (chars[i] == temp)
        //        {
        //            tempCount++;
        //        }
        //        else
        //        {
        //            if (tempCount > maxCount)
        //            {
        //                maxCount = tempCount;
        //                mostUsedChar = temp;
        //            }

        //            tempCount = 1;
        //            temp = chars[i];
        //        }
        //    }

        //    if (tempCount > maxCount)
        //    {
        //        maxCount = tempCount;
        //        mostUsedChar = temp;
        //    }

        //    Console.WriteLine(mostUsedChar);
        //    Console.WriteLine(maxCount);
        //} 
        #endregion
        { 
            int a=3, b=4, c=5;
            TypeOfTriangle(a, b, c);
        }

        public static void TypeOfTriangle (int a1, int a2, int a3)
        {
            if (a1 * a1 + a2 * a2 == a3 * a3 || a2 * a2 + a3 * a3 == a1 * a1 || a1 * a1 + a3 * a3 == a2 * a2)
            {
                Console.WriteLine("Duzbucaqli ucbucaqdir");
            }
            else if (a1 == a2 && a2 == a3)
            {
                Console.WriteLine("Beraber terefli ucbucaqdir");
            }
            else if (a1 == a2 || a2 == a3 || a1 == a3)
            {
                Console.WriteLine("Beraber yanli ucbucaqdir");
            }
            else
            {
                Console.WriteLine("Muxtelif terefli ucbucaqdir");
            }
        }
    }
}
