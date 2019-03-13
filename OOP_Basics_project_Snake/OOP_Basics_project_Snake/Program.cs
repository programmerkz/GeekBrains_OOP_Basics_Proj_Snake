using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOP_Basics_project_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> pList = new List<Person>();
            pList.Add(new Person());
            pList.Add(new Person("Vasya", 1984));
            pList.Add(new Person("Vova", 1985));

            List<Employee> eList = new List<Employee>();
            eList.Add(new Employee(pList[0], "IBM"));
            eList.Add(new Employee(pList[1], "IBM"));
            eList.Add(new Employee(pList[2], "Sony"));

            foreach (Person p in pList)
                Console.WriteLine(p);

            foreach (Employee emp in eList)
                Console.WriteLine(emp);


            Console.WriteLine("Modifications...");
            Person ppp = eList[0];
            Employee eee = (Employee)ppp;
            //Employee eee = (Employee) new Person();  // <<<--- так делать нельзя, т.к. не хватает "запчастей" (методов, полей и т.п.)

            foreach (Person p in pList)
                Console.WriteLine(p);

            foreach (Employee emp in eList)
                Console.WriteLine(emp);





            Console.ReadLine();
        }
    }
}
