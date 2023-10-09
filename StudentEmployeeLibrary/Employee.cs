using System;


namespace StudentEmployeeLibrary
{
    public class Employee : Student
    {

        private int empid;
        public int Empid
        {
            get { return empid; }
            set { empid = value; }
        }


        private string empname;
        public string EmpName
        {
            get { return empname; }
            set { empname = value; }
        }

        private int sal;
        public int Salary
        {
            get { return sal; }
            set { sal = value; }
        }

        public new void Calculate()
        {
            float hra = 0;
            float da = 0;
            float special_Allowance = 0;
            if ((sal > 10000) && (sal < 20000))
            {
                hra = (sal * 10 / 100);
                da = (sal * 5 / 100);
                special_Allowance = (sal * 10 / 100);
            }
            if ((sal > 20000) && (sal < 30000))
            {
                hra = (sal * 12 / 100);
                da = (sal * 7 / 100);
                special_Allowance = (sal * 12 / 100);
            }

            Console.WriteLine(" Salary : {0} \n HRA:  {1} \n DA : {2} \n Special Allowance : {3} \n Total Salary : {4}", sal, hra, da, special_Allowance, sal + hra + da + special_Allowance);

        }


    }

}
