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
        #region Task-7
        //{ 
        //    int a=3, b=4, c=5;
        //    TypeOfTriangle(a, b, c);
        //}

        //public static void TypeOfTriangle (int a1, int a2, int a3)
        //{
        //    if (a1 * a1 + a2 * a2 == a3 * a3 || a2 * a2 + a3 * a3 == a1 * a1 || a1 * a1 + a3 * a3 == a2 * a2)
        //    {
        //        Console.WriteLine("Duzbucaqli ucbucaqdir");
        //    }
        //    else if (a1 == a2 && a2 == a3)
        //    {
        //        Console.WriteLine("Beraber terefli ucbucaqdir");
        //    }
        //    else if (a1 == a2 || a2 == a3 || a1 == a3)
        //    {
        //        Console.WriteLine("Beraber yanli ucbucaqdir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Muxtelif terefli ucbucaqdir");
        //    }
        //} 
        #endregion
        #region Task-8
        //{
        //    string str = "Market";
        //    MiddleSymbol(str);
        //}
        //public static void MiddleSymbol(string s)
        //{
        //    int len = s.Length;
        //    if (len % 2 == 0)
        //    {
        //        Console.WriteLine(s[len / 2 - 1] + "" + s[len / 2]);
        //    }
        //    else
        //    {
        //        Console.WriteLine(s[len / 2]);
        //    }
        //} 
        #endregion
        #region Task-9
        //{ 
        //    int number = 23569;
        //    Console.WriteLine(SumOfPrimeNumbers(number));
        //}

        //public static int SumOfPrimeNumbers (int num)
        //{
        //    int sum = 0;
        //    while (num > 0)
        //    {
        //        int digit = num % 10;
        //        int count = 0;
        //        for (int i = 2; i < digit; i++)
        //        {
        //            if (digit % i != 0)
        //            {
        //                count++;
        //            }
        //        }
        //        if (count == digit - 2)
        //        {
        //            sum += digit;

        //        }
        //        num /= 10;
        //    }
        //    return sum;
        //} 
        #endregion
        #region Task-10
        //{
        //    int n = 296;
        //    BiggestPossibleNumber(n);

        //}
        //public static void BiggestPossibleNumber(int number)
        //{
        //    if (number < 100 || number > 999)
        //    {
        //        Console.WriteLine("3 reqemli eded daxil edin");
        //    }
        //    else
        //    {
        //        int d1 = number % 10;
        //        int d2 = (number / 10) % 10;
        //        int d3 = number / 100;
        //        if (d1 > d2 && d1 > d3)
        //        {
        //            if (d2 > d3)
        //            {
        //                Console.WriteLine($"{d1}{d2}{d3}");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"{d1}{d3}{d2}");
        //            }
        //        }
        //        else if (d2 > d1 && d2 > d3)
        //        {
        //            if (d1 > d3)
        //            {
        //                Console.WriteLine($"{d2}{d1}{d3}");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"{d2}{d3}{d1}");
        //            }
        //        }
        //        else
        //        {
        //            if (d1 > d2)
        //            {
        //                Console.WriteLine($"{d3}{d1}{d2}");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"{d3}{d2}{d1}");
        //            }
        //        }
        //    }
        //} 
        #endregion
        #region Task-11
        //{
        //    int n = 1429;
        //    Console.WriteLine(IsIncreasing(n));
        //}
        //public static string IsIncreasing(int num)
        //{
        //    int numcopy = num;
        //    int count = 0;
        //    int length = 0;
        //    while (numcopy > 0)
        //    {
        //        numcopy /= 10;
        //        length++;
        //    }
        //    int[] digits = new int[length];
        //    numcopy = num;
        //    for (int i = length - 1; i >= 0; i--)
        //    {
        //        digits[i] = numcopy % 10;
        //        numcopy /= 10;
        //    }

        //    for (int i = 1; i < digits.Length; i++)
        //    {
        //        if (digits[i] >= digits[i - 1])
        //        {
        //            count++;
        //        }
        //    }

        //    if (count == digits.Length - 1)
        //    {
        //        return "artan siradir";
        //    }
        //    else
        //    {
        //        return "artan sira deyil";
        //    }
        //} 
        #endregion
        {
            int n = 44444444;
            Console.WriteLine(IsThereAnyDifferentNumber(n));
        }
        public static string IsThereAnyDifferentNumber(int num)
        {
            string result = "Butun reqemler eynidir";
            int digit = num % 10;
            while (num > 0)
            {
                if (num % 10 != digit)
                {
                    result = "Ferqli reqemler var";
                    break;
                }
                num /= 10;
            }
            return (result);
        }
    }
}
