using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
   
         public class StudEmployMain
        {
            static void Main(string[] args)
            {

                Student s2 = new Student(101, "Vikram");
                Console.WriteLine($" Student Id : {s2.StudentId} \n " +
                                  $"Student Name : {s2.StudentName}");
                Console.WriteLine();
                Student s3 = new Student(103, "Vika", 23);
                s3.Maths = 80;
                s3.English = 85;
                s3.Science = 90;
                Console.WriteLine($" Student Id : {s3.StudentId} \n Student Name : {s3.StudentName} \n Student Age : {s3.StudentAge}");
                s3.Calculate();
                Console.WriteLine("------------------");
                Employee employee = new Employee();
                employee.Empid = 001;
                employee.EmpName = "Vicky";
                employee.Salary = 21000;
                employee.Calculate();
                Console.ReadLine();
            }
        }
 }
