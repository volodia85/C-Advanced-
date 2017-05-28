namespace _01.Students_by_Group
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();

            var student = new Student();
            student.name = input[0];
            student.secondName = input[1];
            student.group = input[2];

            var listOfInput = new List<Student>();

            

            while (!student.name.Equals("END"))
            {
                listOfInput[0] = student;

                var isGroup = student.group.Equals("2");
                if (isGroup)
                {
                    listOfInput[0] = student;
                }

                input = Console.ReadLine().Split(' ').ToList();
                
            }
            
        }

        public class Student
        {
            public string name { get; set; }
            public string secondName { get; set; }
            public string group { get; set; }
        }
    }
}
