using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public class Employee : IEmployee
    {
        public int flag;
        public string Id, Name, City, Email = "only for HR", Skype = "only for developer", id1;
        public Employee()
        {

        }
        public Employee(string id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }


        public virtual void Display()
        {
            Console.WriteLine("\n Details are : \n Id: {0} \n Name: {1} \n City: {2} ", Id, Name, City);
        }
        public void Display(List<Employee> list)
        {
            foreach (Employee employee1 in list)
            {
                employee1.Display();
            }
        }
        public void Find(List<Employee> list)
        {
            Console.WriteLine("\n Enter the id of the employee to find");
            id1 = Console.ReadLine();
            foreach (Employee employee2 in list)
            {
                if (employee2.Id == id1)
                {
                    Console.WriteLine("the employee is:\n");
                    employee2.Display();
                    flag = 1;

                }

            }
            if (flag == 0)
            {
                Console.WriteLine("not found");
            }
        }
        // ~Employee()
        // {
        //     Console.WriteLine("\n Details are : \n Id: {0} \n Name: {1} \n City: {2} \n Email: {3}", Id, Name, City, Email);

        // }
    }

    public class Hr : Employee
    {
        public Hr()
        {

        }
        public Hr(string id, string name, string city, string email) : base(id,name,city)
        {
            Email = email;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("email: {0}",Email);
        }
       
    }

    public class Developer : Employee, IEmployee
    {
        public Developer()
        {

        }
        public Developer(string id, string name, string city, string skype) :base(id,name,city)
        {
            
            Skype = skype;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Skype address: {0}", Skype);
        }
    }
}
