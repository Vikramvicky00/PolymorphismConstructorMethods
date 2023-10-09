using System;


namespace StudentEmployeeLibrary
{
    public class Student
    {

        private int maths;
        public int Maths
        {
            get { return maths; }
            set { maths = value; }
        }

        private int science;
        public int Science
        {
            get { return science; }
            set { science = value; }
        }

        private int english;
        public int English
        {
            get { return english; }
            set { english = value; }
        }

        private int _studid;
        public int StudentId
        {
            get { return _studid; }
            set { _studid = value; }
        }

        private string _studentname;

        public string StudentName
        {
            get { return _studentname; }
            set { _studentname = value; }
        }

        private int age;

        public int StudentAge
        {
            get { return age; }
            set { age = value; }
        }


        public Student()
        {
        }
        public Student(int Studid, string Studname)
        {
            StudentId = Studid;
            StudentName = Studname;
        }
        public Student(int Studid, string Studname, int Age)
        {
            StudentId = Studid;
            StudentName = Studname;
            StudentAge =Age;
        }


        public void Calculate()
        { 
            Console.WriteLine("Total Marks : {0}", Maths + English + Science);
        }

    }
}
