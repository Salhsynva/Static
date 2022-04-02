using System;
using ClassLibrary;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullname;
            string groupNo;
            byte age;
            do
            {
                Console.WriteLine("telebenin adi ve soyadini daxil edin: ");
                fullname = Console.ReadLine();
            } while (!Student.CheckFullname(fullname));

            do
            {
                Console.WriteLine("telebenin qrup nomresini daxil edin: ");
                groupNo = Console.ReadLine();
            } while (!Student.CheckGroupNo(groupNo));

            Console.WriteLine("telebenin yasini daxil edin: ");
            age = Convert.ToByte(Console.ReadLine());
            
            Student student = new Student(fullname, groupNo, age);
            student.GetInfo();

        }
    }
}
