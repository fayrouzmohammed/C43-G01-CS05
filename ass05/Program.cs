// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Runtime;

namespace Assignment5
{
    internal class Program
    {

        #region Q 1-
        /*public static void SwapByValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void SwapByRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }*/
        #endregion

        #region Q 2-
        /* public static int SumArrByValue(int[] arr)
         {
             int sum = 0;
             if (arr != null)
             {
                 arr = new int[] { 10, 20, 30 };
                 for (int i = 0; i < arr.Length; i++)
                 {
                     sum += arr[i];
                 }
             }
             return sum;

         }

         public static int SumArrByRef(ref int[] arr)
         {
             int sum = 0;
             if (arr != null)
             {
                 arr = new int[] { 10, 20, 30 };
                 for (int i = 0; i < arr.Length; i++)
                 {
                     sum += arr[i];
                 }
             }
             return sum;
         }
 */



        #endregion

        #region Q3-

        /*        public static void SumSub(int x, int y, out int sum, out int sub)
                {
                    sum = x + y;
                    sub = x - y;
                }*/
        #endregion

        #region Q4-
        /*        public static int sumOfDigits(int num)
                {
                    int sum = 0;
                    while (num > 0)
                    {
                        int R = num % 10;
                        sum += R;
                        num /= 10;
                    }

                    return sum;
                }*/
        #endregion

        #region Q5-

        /*        public static bool IsPrime(int num)
                {
                    int n = 0;
                    if (num == 2) return true;
                    if (num % 2 == 0 ) { return false; }
                    for (int i = 3; i <= num; i += 2)
                    {
                        if (num % i == 0) 
                        {
                            n++; 
                        }
                    }
                    if (n == 1) { return true; }
                    else
                    return false;
                }*/
        #endregion


        #region Q6-
        /*  public static void MinMaxArray(ref int[] arr, out int min, out int max)
          {
              // { 1, 2, 3, 5, 7, 0, 4 }


              if (arr == null || arr.Length == 0)
              {
                  min = 0;
                  max = 0;
                  return;
              }

              max = arr[0];
              min = arr[0];

             for (int i = 1; i < arr.Length; i++)
             {
                  if (arr[i] > max) max = arr[i]; //2 3 5 7
                  if (arr[i] < min) min = arr[i]; //0
             }

          }*/

        #endregion

        #region Q7-
        /*    public static long Factorial(int num)
            {
                long fact = 1;
                if ( num == 0 || num == 1)
                {
                    fact = 1;
                }
                else
                    for (int i = 2; i <= num; i++)
                    {
                        fact *= i;
                    }
                return fact;
            }*/

        #endregion

        #region Q8-
        /*public static string ChangeChar(string word, char a, int position)
        {
            string replace = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (i == position)
                {
                    replace += a;
                }
                else
                {
                    replace += word[i];
                }
            }
            return replace;
        }*/


        #endregion


        static void Main(string[] args)
        {
            #region Q 1-
            /* int a = 10;
             int b = 5;
             SwapByValue(a, b);
             Console.WriteLine("a= " + a);
             Console.WriteLine("b= " + b);
             SwapByRef(ref a, ref b);
             Console.WriteLine("a= " + a);
             Console.WriteLine("b= " + b);*/
            #endregion

            #region Q 2-
            /* int[] numbers = { 1, 2, 3, 4, 5 };
             int sum=SumArrByValue(numbers);
             Console.WriteLine(sum);
             Console.WriteLine(numbers[0]);

             int sum1=SumArrByRef(ref numbers);
             Console.WriteLine(sum1);
             Console.WriteLine(numbers[0]);
 */


            #endregion

            #region Q3-
            /* int a = 10; int b = 5;
             int sum; int sub;
             SumSub(a, b,out sum,out sub);
             Console.WriteLine("sum= " + sum);
             Console.WriteLine("sub= " + sub);*/
            #endregion

            #region Q4-
            /*
                        Console.Write("enter the number: ");
                        int num = int.Parse(Console.ReadLine());
                        int sum = sumOfDigits(num);
                        Console.WriteLine("result= "+ sum);*/

            #endregion

            #region Q5-
            /* Console.WriteLine(IsPrime(9)); 
             Console.WriteLine(IsPrime(2));
             Console.WriteLine(IsPrime(7));
             Console.WriteLine(IsPrime(22));
             Console.WriteLine(IsPrime(21));*/
            #endregion

            #region Q6-
            /* int[] arr = { 1, 2, 3, 5, 7, 0, 4 };
             int min; int max;
             MinMaxArray(ref arr, out min, out max);
             Console.WriteLine(min+ " " + max);
 */

            #endregion

            #region Q7-
            /* long result = Factorial(2);
             Console.WriteLine(result);*/

            #endregion

            #region Q8-
         /*   Console.Write("enter string: ");
            string word=Console.ReadLine();
            Console.Write("enter char : ");
            char cha =Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("enter position of character: ");
            int pos=int.Parse(Console.ReadLine());
            string result =ChangeChar(word, cha , pos);

            Console.WriteLine("After Change " + result);*/
            #endregion

        }
    }
}
