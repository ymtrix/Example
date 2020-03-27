using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    public class LinqClass
    {
        IList<Student> studentList;
        public LinqClass() {

           studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };
        }

        //Contains function
        public static void ContainsFunc()
        {
            string[] names = { "Bill", "Steve", "James", "Mohan","Max", "Ali" };
            List<XNames> xnames = new List<XNames>() { new XNames { Name = "Bill" }, new XNames { Name = "Steve" }, new XNames { Name = "James" }, new XNames { Name = "Mohan" } };
            string[] ms = { "Mohan", "Max" };

            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;

            var meds = (from m in names
                        where ms.Any(name => name.Equals(m) || name.Contains(m))
                        select m);
        }

        public void Joins()
        {


            //two tables.
            //var query = from na in names
            //            join ns in ms on names equals ms
            //            select new { na };

            //multiple columns
            //var results = from t1 in context.tb1
            //              join t2 in context.tb2
            //              on new { t1.Col1, t1.Col2, t1.Col3 } equals
            //                  new { t2.Col1, t2.Col2, t2.Col3 }
            //              where t2.Col1 == col1 && t2.Col2 == col2 && t2.Col4 == someString
            //              select t1;

            //var groupJoin = from std in standardList
            //                join s in studentList
            //                on std.StandardID equals s.StandardID
            //                into studentGroup
            //                select new
            //                {
            //                    Students = studentGroup,
            //                    StandardName = std.StandardName
            //                };
        }

        //type of method mix list
        public void TypeOflinq()
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            var stringResult = from s in mixedList.OfType<string>()
                               select s;
        }

        //OrderBy
        public void orderby()
        {
            //simple
            var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);

            var orderByResult = from s in studentList
                                orderby s.StudentName
                                select s;

            var orderByDescendingResult = from s in studentList
                                          orderby s.StudentName descending
                                          select s;

            //orderby then
            var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

            var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
        }

        public void groupby()
        {
            var groupedResult = from s in studentList
                                group s by s.Age;

           var groups =  studentList.GroupBy(x => x.Age);
        }
        
        public void aggregate()
        {
            IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);
        }

        public static void count()
        {

            IList<int> intList = new List<int>() { 10, 21, 30, 45, 50, 30 };

            var totalElements = intList.GroupBy(s => s).Where(x => x.Count() > 1);

            //even element
            var largestEvenElements = intList.Max(i => {
                if (i % 2 == 0)
                    return i;

                return 0;
            });

            //Aggregate 
            //var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);

            //check sequence of 2 lists
            //strList1.SequenceEqual(strList2);

            //Union Query Union
            //Intersect for common in both

            //first list unique elements
            // strList1.Except(strList2);

            //skip from first element
            //strList.Skip(2);

            //take 2 element from first element
            //var newList = strList.Take(2)
        }








    }




    public class XNames
    {
        public string Name { set; get; } = String.Empty;
    }

    public class Student
    {
        public int StudentID { set; get; } 
        public int Age { set; get; }
        public string StudentName { set; get; } = String.Empty;
    }
}
