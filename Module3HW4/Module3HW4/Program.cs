using System;
using System.Collections.Generic;
using Module3HW4.DelegateTask;
using Module3HW4.LinqTask;

namespace Module3HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();
            program.DoDelegateTask();
            program.DoLinqTask();
        }

        public void DoDelegateTask()
        {
            var firstTask = new FirstTask();
            var sum = 0D;
            firstTask.TryCatch(() => sum = firstTask.CountSum(7, 7));
            Console.WriteLine(sum);
        }

        public void DoLinqTask()
        {
            var secondTask = new SecondTask();
            var list = new List<Contact>();
            list.Add(new Contact() { FirstName = "Neil", LastName = "Binkley", Age = 34, PhoneNumber = "972-671-0874" });
            list.Add(new Contact() { FirstName = "Lauren", LastName = "Cuevas", Age = 19, PhoneNumber = "610-235-7220" });
            list.Add(new Contact() { FirstName = "Darlene", LastName = "Mullins", Age = 18, PhoneNumber = "503-232-1248" });
            list.Add(new Contact() { FirstName = "Mary", LastName = "Calderon", Age = 20, PhoneNumber = "928-566-3280" });
            list.Add(new Contact() { FirstName = "Robert", LastName = "Clark", Age = 27, PhoneNumber = "213-827-5284" });
            list.Add(new Contact() { FirstName = "Leroy", LastName = "Vargas", Age = 50, PhoneNumber = "404-555-4250" });

            secondTask.CallLinqMethods(list);
        }
    }
}
