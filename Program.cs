using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {

        //public static void Main(string[] args)
        //{

        //    //bool x = testsp();
        //    //sppli();

        //    //test();
        //    //dynamic a = 1;
        //    //a = "abc";

        //    //var b = a;
        //    //string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
        //    //string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };


        //    //Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        //    //Console.ReadKey();
        //}

        public static IEnumerable<string> Prefixes(IEnumerable<string> words, int length)
        {
           return  words.Where(a => a.Count() > length - 1).ToArray().Select(x => x.Substring(0, 3)).Distinct();
        }

        public static void PairArray(int[] arr, int sum)
        {
            for (int index = 0; index < arr.Length-1; index++)
            {
                for (int jindex = index+1; jindex < arr.Length; jindex++)
                {
                    if (arr[index] + arr[jindex] == sum)
                    {
                        Console.WriteLine(String.Format("Elements Found {0} + {1} = {2}", arr[index], arr[jindex], sum));
                    }
                }
               
            }
          
        }

        public static void sumArray(int[] arr)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                int sum = 0;
                List<int> element = new List<int>();

                for (int i = index; i < arr.Length; i++)
                {
                    element.Add(arr[i]);
                    sum += arr[i];
                    
                    if (sum == 0)
                    {
                        Console.Write("Elements Found ");
                        element.ForEach(a => Console.Write(String.Format("{0} ,", a)));
                        Console.WriteLine(String.Format(" Sum {0} ", sum));

                    }
                }
            }
        }

        public static void sumSubArray(int[] arr,int sum)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                int result = 0;
                List<int> element = new List<int>();

                for (int i = index; i < arr.Length; i++)
                {
                    element.Add(arr[i]);
                    result += arr[i];

                    if (sum == result)
                    {
                        Console.Write("Elements Found ");
                        element.ForEach(a => Console.Write(String.Format("{0} ,", a)));
                        Console.WriteLine(String.Format(" Sum {0} ", sum));

                    }
                }
            }
        }

        public static void Main(string[] args)
        {

            //LinqClass.ContainsFunc();

            LinqClass.count();
           
            Console.ReadKey();
        }

        public void testfunc()
        {
            //int[] A = { 2, 0, 2, 1, 4, 3, 1, 0 };
            ////var ele = A.Union(A);
            ////var ele = A.Intersect(A);
            //var ele = A.Distinct();
            ////int[] A = { 1, 2, 3, 4, 2 };
            ////var ele = A.GroupBy(a => a).Where(a => a.Count() > 1);

            //foreach (var item in ele)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] A = { 0, 0, 1, 0, 1, 1, 0, 1, 0, 0 };
            //Array.Sort(A);

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write(String.Format(" {0} ", A[i]));
            //}

            //int[] a = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
            //sumArray(a);

            //int[] A = { 5, 6, -5, 5, 3, 5, 3, -2, 0 };
            //int sum = 8;
            //sumSubArray(A,sum);


            //int[] A = { 8, 7, 2, 5, 3, 1 };
            //int sum = 10;
            //PairArray(A,sum);

            //foreach (var p in Prefixes(new string[] { "many", "manly", "men", "maybe", "my" }, 3))
            //{
            //    Console.WriteLine(p);
            //}
            //    int[] arr = { 2, 1, 2 };
            //int res = 0;


            //for (int i = startingAmount - 1; i >= index; i--)
            //{
            //    res += arr[i];
            //    startingAmount = startingAmount - newEvery
            //}

            //return res;






            //int[] arr = { 2, 1, 2 };
            //int res = 0;
            //int index = 0;

            //for (int i = startingAmount - 1;  i >= index;  i--)
            //{
            //    res += arr[i];
            //    index += newEvery;
            //}

            //return res;


            //   int startingAmount = 3;
            //   int newEvery = 2;

            //   if((startingAmount + newEvery) % 3 == 0)


            //   string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            //   string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };

            //   var nam = names1.Union(names2);
            //   var nam1 = names1.Intersect(names2);

            //   int[] input = new int[] { 1, 3, 3, 4, 13, -2 };

            //   int sum  = input.Sum();
            //   bool result;
            //   if (sum % 2 == 0)
            //       result = true;


            //   // int[] arr = new int[] { 4, 5, 8, 1, 3, 9, 7, 11, 100, 74, 83, 65 };
            //int[] arr = new int[] { 1, 3, 3, 4, 5 };
            //   arr.Where(a => a == 0);
            //   int xp = arr.Sum();

            //   var ii = arr.Max();
            //  var t= arr.Min();

            //  var xx =  arr.GroupBy(a => a).Where(x => x.Count() > 1);


            //   //int[] arr = new int[] { 2, 7, 5, 5 };
            //   int[] set1 = new int[(1 + arr.Length) / 2];
            //   int[] set2 = new int[(1 + arr.Length) / 2];

            //   divideInEqualSums(arr, set1, set2);
        }

        private static void divideInEqualSums(int[] arr, int[] set1, int[] set2)
        {
            int setSize = set1.Length;
            Array.Sort(arr);

            int pos1 = 0;
            int pos2 = 0;

            int i = arr.Length - 1;

            int sum1 = 0;
            int sum2 = 0;
            while (pos1 < setSize && pos2 < setSize)
            {
                if (sum1 < sum2)
                {
                    set1[pos1] = arr[i];
                    pos1++;
                    sum1 += arr[i];
                }
                else
                {
                    set2[pos2] = arr[i];
                    pos2++;
                    sum2 += arr[i];
                }
                i--;
            }

            while (i >= 0)
            {
                if (pos1 < setSize)
                    set1[pos1++] = arr[i];
                else
                    set2[pos2++] = arr[i];
                i--;
            }

            printArrayWithSum(arr);
            printArrayWithSum(set1);
            printArrayWithSum(set2);
        }

        static void printArrayWithSum(int[] arr)
        {
            int sum1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum1 += arr[i];
                Console.Write(arr[i] + ",");
            }
            Console.Write(" = " + sum1);
            Console.WriteLine("");
        }

        
    

  
    }



public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            string[] namesArray =  new string[names1.Length + names1.Length];
            Array.Copy(names1, 0, namesArray, 0, names1.Length);
            Array.Copy(names2, 0, namesArray, names1.Length, names2.Length);
            return namesArray.Distinct().ToArray();

        }

       


    }


}
