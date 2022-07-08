
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisionDelegateDemo
{
    internal class Program
    {
        public static int CompareNames(Student s1, Student s2)
        {
            return  s1.Name.CompareTo(s2.Name);
             
        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { Id = 1, Name = "Neha", Marks = 120});
            list.Add(new Student() { Id = 2, Name = "Pranita", Marks = 300});
            list.Add(new Student() { Id = 4, Name = "Payal", Marks = 200});
            list.Add(new Student() { Id = 3, Name = "Jems", Marks = 50});
            list.Add(new Student() { Id = 5, Name = "Tony", Marks = 10});

            Comparison<Student> obj = new Comparison<Student>(CompareNames);


            //list.Sort(obj);
            //list.Sort(CompareNames);
            //list.Sort(delegate (Student s1, Student s2)
            //{
            //    return (s1.Name.CompareTo(s2.Name));
            //});

            list.Sort((s1, s2) => s1.Name.CompareTo(s2.Name));

            foreach (var item in list)
            {
                Console.WriteLine("Id = " + item.Id + "\t Name = " + item.Name + "\t Marks = " + item.Marks);
            }

            Console.ReadLine();

        }
    }
}
