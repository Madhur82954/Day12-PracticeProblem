using System;
using System.Collections.Generic;
using System.Linq;

namespace Day12_PracticeProblem
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int TotalMarks { get; set; }
    }
    internal class Program
    {
        public void RetrieveAge(List<Student> students)
        {
            Console.WriteLine("-----------------");
            foreach(Student student in students.FindAll(e=>e.Age>12 && e.Age < 18).ToList())
            {
                Console.WriteLine("Id : " + student.Id + " Name : " + student.Name + " PhoneNumber: " + student.PhoneNumber + " Address: " + student.Address + " Age : " + student.Age+" Total Marks : "+student.TotalMarks);
            }
        }
        public void Sort(List<Student> students)
        {
            Console.WriteLine("-----------------");
            foreach(Student student in students.OrderByDescending(e => e.TotalMarks).ToList())
            {
                Console.WriteLine("Id : " + student.Id + " Name : " + student.Name + " PhoneNumber: " + student.PhoneNumber + " Address: " + student.Address + " Age : " + student.Age + " Total Marks : " + student.TotalMarks);
            }
        }
        public void RetrieveFirst3(List<Student> students)
        {
            Console.WriteLine("------------------");
            foreach(Student student in students.Take(3).ToList())
            {
                Console.WriteLine("Id : " + student.Id + " Name : " + student.Name + " PhoneNumber: " + student.PhoneNumber + " Address: " + student.Address + " Age : " + student.Age + " Total Marks : " + student.TotalMarks);
            }
        }
        public void CheckNameExists(List<Student> students)
        {
            Console.WriteLine("--------------------");
            foreach(Student student in students.Where(e=>e.Name=="Madhur"))
            {
                Console.WriteLine("Id : " + student.Id + " Name : " + student.Name + " PhoneNumber: " + student.PhoneNumber + " Address: " + student.Address + " Age : " + student.Age + " Total Marks : " + student.TotalMarks);
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student {Id=1,Name="Madhur",PhoneNumber=9832648247,Address="16 Old Jaganath Vihar Colony",Age=13,TotalMarks=80},
                new Student {Id=2,Name="Karan",PhoneNumber=9374234872,Address="19 OHBC vihar",Age=23,TotalMarks=75},
                new Student {Id=3,Name="Raghav",PhoneNumber=8923443282,Address=" 75 bagichi colony",Age=17,TotalMarks=79},
                new Student {Id=4,Name="Pranav",PhoneNumber=9824827382,Address="22 OHBC Colony ",Age=23,TotalMarks=85},
            };
            foreach(Student student in students)
            {
                Console.WriteLine("Id : "+student.Id+" Name : "+student.Name+" PhoneNumber: "+student.PhoneNumber+" Address: "+student.Address+" Age : "+student.Age+" Total Marks : "+student.TotalMarks);
            }
            Program program = new Program();
            program.RetrieveAge(students);
            program.Sort(students);
            program.RetrieveFirst3(students);
            program.CheckNameExists(students);
        }
    }
}
