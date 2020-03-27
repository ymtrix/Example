using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Class1
    {
        public static bool testsp()
        {
           int[] input = new int[] { 1, 3, 3, 4, 5 };
        int sum = 0;
            foreach (int item in input)
            {
                sum += item;
            }

    int left = 0;
    int right = sum;
            for (int i = 0; left != right && i<input.Length; i++)
            {
                left += input[i];
                right -= input[i];
            }
            return left == right;
        }

        public static int SplitArray(int[] input)
        {

            int arraySum = 0;

            for (int index = 0; index < input.Length; index++)
            {
                arraySum += input[index];

                int arraySum2 = 0;
                for (int i = index + 1; i < input.Length; i++)
                {
                    arraySum2 += input[i];
                }

                if (arraySum == arraySum2)
                {
                    return index = +1;
                }

            }

            return -1;

            /// return true;
            // Your code goes here
        }

        public static void test()
        {
            int[] input = new int[] { 1, 3, 3, 4, 5 };
            //int[] input = new int[] { 1, 2, 3, 4,5, 5 };
            int splitpoint = SplitArray(input);
            if (splitpoint == -1 || splitpoint == input.Length)
            {
                string s = "not po";
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (splitpoint == i)
                {

                }

                Console.WriteLine(input[i]);
            }
        }

        public static bool sppli()
        {
            int fistnum = 0;
            int Arraysum = 0;
            int xarraysum = 0;

            int pos = 0;
            // int[] input = new int[] { 1, 3, 3, 4, 5 };
            //int[] input = new int[] { 2, 2, 4, 5 };
            int[] input = new int[] { 2, 7, 4, 5 };

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }

            if (sum % 2 == 0)
            {

            }

            int arrayLength = 0;

            if (input.Length % 2 != 0)
            {
                arrayLength = input.Length / 2;
            }

            //int x = Math.Floor(arrayLength);
            //int[] firstArray = new int[];

            if (sum % 2 == 0)
            {
                int remainder = sum / 2;


                for (int i = input.Length - 1; i > 0; i--)
                {

                    for (int j = 0; j < input.Length - 1; j++)
                    {
                        if (input[i] + input[j] == remainder)
                        {
                            fistnum = input[i];
                            //secnum = input[j];
                            pos = input[j - 1];
                            input[j - 1] = fistnum;
                            input[i] = pos;
                            pos = j;

                            i = 6;
                            break;
                        }
                    }

                    if (i == 6)
                        break;
                }



                for (int i = 0; i <= pos; i++)
                {
                    Arraysum += input[i];
                }

                for (int i = pos + 1; i < input.Length; i++)
                {
                    xarraysum += input[i];
                }

                if (Arraysum == xarraysum)
                { return true; }

            }



            return false;
        }

        public bool splitArray(int[] input)
        {
            if (input.Length < 7)
                return false;
            int[] sum = new int[input.Length];
            sum[0] = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                sum[i] = sum[i - 1] + input[i];
            }


            for (int j = 3; j < input.Length - 3; j++)
            {
                List<int> set = new List<int>();
                for (int i = 1; i < j - 1; i++)
                {

                    if (sum[i - 1] == sum[j - 1] - sum[i])
                    {
                        set.Add(sum[i - 1]);
                    }
                }
                for (int k = j + 2; k < input.Length - 1; k++)
                {

                    if (sum[input.Length - 1] - sum[k] == sum[k - 1] - sum[j] && set.Contains(sum[k - 1] - sum[j]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool splitMyArray(int[] input)
        {
            int sum = input.Sum();
            if (sum % 2 == 0)
                return true;

            return false;
        }
    }
}
