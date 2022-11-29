/*
Write a program in C# Sharp to find the n-th Maximum
grade point achieved by the students from the list of students. 
Test Data :
Which maximum grade point(1st, 2nd, 3rd, ...) you want to find : 3
Expected Output:
Id : 7, Name : David, achieved Grade Point : 750
Id : 10, Name : Jenny, achieved Grade Point : 750 
 */

namespace MaximumGrade
{
    public class Students
    {
        public string StuName { get; set; }
        public int GrPoint { get; set; }
        public int StuId { get; set; }

        public List<Students> GtStuRec()
        {
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });
            return stulist;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int grade;
            
            Console.Write("\nLINQ : Find the nth Maximum Grade Point achieved " +
                "by the students from the list of student : ");
            Console.Write("\n-------------------------------------------------" +
                "-----------------------------------------\n");

            Console.Write("Which maximum grade point(1st, 2nd, 3rd, ...) " +
                "you want to find  : ");
            grade = Convert.ToInt32(Console.ReadLine());

            var students = new Students();
            List<Students> studentList = students.GtStuRec();


            IEnumerable<Students> bestStudents = from z in studentList
                                                 orderby z.GrPoint descending 
                                                 select z;
            var rank = bestStudents.Distinct();
            var x = rank.ElementAt(grade);
            foreach (var item in bestStudents)
            {
                if (item.GrPoint == x.GrPoint)
                {
                    Console.WriteLine("Id : {0}, Name : {1}, achieved Grade Point : {2}",
                        item.StuId, item.StuName, item.GrPoint);
                }
                  
            }

        }
    }
}