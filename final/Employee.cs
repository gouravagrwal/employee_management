using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public class Employee :  IEmployee //inheriting interface(use of inheritance)
    {
        public int flag;
        public string Id, Name, City,idToFind;
        public Employee() //defining default constructor
        {

        }
        public Employee(string id, string name, string city) //constructor overloading
        {
            Id = id;
            Name = name;
            City = city;
        }


        public virtual void Display()  //method overiding,method overloading
        {
            Console.WriteLine("\n Details are : \n Id: {0} \n Name: {1} \n City: {2} ", Id, Name, City);
        }
        public void Display(List<Employee> list) //method overloading
        {
            foreach (Employee employee1 in list)
            {
                employee1.Display();
            }
        }
        public void Find(List<Employee> list)
        {
            Console.WriteLine("\n Enter the id of the employee to find");
            idToFind = Console.ReadLine();
            foreach (Employee employee2 in list)
            {
                if (employee2.Id == idToFind)
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
        
        public void Dispose() //Dispose function to clear the memory after use
        {
            Id = ""; 
            Name= "";
            City = "";
            Console.WriteLine("Memory Cleared");
            Console.ReadKey();
        }
        ~Employee() //destructor
         {
             Dispose();
         }
    }

    public class Hr : Employee //inheritance
    {
        string Email;
        public Hr() //default conctructor
        {

        }
        public Hr(string id, string name, string city, string email) : base(id,name,city) //inheriting base  class constructor and defining constructor for this class
        {
            Email = email;
        }
        public override void Display() //overriding the display function in base class
        {
            base.Display();
            Console.WriteLine("email: {0}",Email);
        }
       
    }

    public class Developer : Employee //inheritance
    {
        string Skype;
        public Developer() //default constructor
        {

        }
        public Developer(string id, string name, string city, string skype) :base(id,name,city) //inheriting the constructor from the base class
        {
            
            Skype = skype;
        }
        public override void Display() // overriding the display function in the base class
        {
            base.Display();
            Console.WriteLine("Skype address: {0}", Skype);
        }
    }
}
