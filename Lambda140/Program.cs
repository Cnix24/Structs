using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda140
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>() {
                new Employee() { firstName = "Joe", lastName = "Abeln", Id = 1 },
                new Employee() { firstName = "Jeff", lastName = "Attl", Id = 2 },
                new Employee() { firstName = "Joe", lastName = "Schmoe", Id = 3 },
                new Employee() { firstName = "Calvin", lastName = "Attl", Id = 4 },
                new Employee() { firstName = "Dana", lastName = "Raber", Id = 5 },
                new Employee() { firstName = "Kona", lastName = "Abeln", Id = 6 },
                new Employee() { firstName = "Korra", lastName = "Attl", Id = 7 },
                new Employee() { firstName = "Jordan", lastName = "Pearce", Id = 8 },
                new Employee() { firstName = "Chris", lastName = "Attl", Id = 9 },
                new Employee() { firstName = "Jon", lastName = "Smith", Id = 10 }
            };


            List<Employee> joeList = new List<Employee>();
            foreach (Employee employee in employeeList)
            {
               
                if ( employee.firstName == "Joe")
                {
                    joeList.Add(employee);
                }     
            };
            foreach (Employee employee in joeList)
            {
                Console.WriteLine("The last name of every employee named Joe: " + employee.lastName);
            }

            List<Employee> joeLambdaList = employeeList.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee employee in joeLambdaList)
            {
                Console.WriteLine("The last name of every employee named Joe: "+ employee.lastName);
            }

            List<Employee> moreThan5List = employeeList.Where(x => x.Id > 5).ToList();
            foreach (Employee employee in moreThan5List)
            {
                Console.WriteLine("The employees with an ID larger than 5: " + employee.firstName);
            }

            Console.ReadLine();


        }
    }
}
