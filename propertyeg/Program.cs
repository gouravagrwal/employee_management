using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertyeg
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int choice, flag=0;

            List<Employee> list = new List<Employee>();
           

            while (true)
            {

                Console.WriteLine("\n0.Exit \n 1.Register \n 2.Find \n 3.Display \n 4.Send message");
                choice = Convert.ToInt32(Console.ReadLine());

                Employee employee = new Employee();

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        employee.Register();
                        list.Add(employee);
                        Console.WriteLine("Employee Registered\n");
                        employee.Display();
                        break;

                    case 2:
                        Console.WriteLine("Enter the id of the employee to find");
                        string id1 = Console.ReadLine();

                        foreach(Employee employee1 in list)
                        {
                            if (employee1.Id == id1)
                            {
                                Console.WriteLine("the employee is:\n");
                                employee1.Display();
                                flag = 1;

                            }
                           
                        }
                        if(flag==0)
                        Console.WriteLine("Not found");
                        Console.ReadKey();
                        break;

                    case 3:
                        {
                            employee.Display(list);
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine("Enter the id of the employee to send message");
                            string y = Console.ReadLine();

                            foreach (Employee employee2 in list)
                            {
                                if (employee2.Id == y)
                                {
                                    Console.WriteLine("\nthe message is send to:\t");
                                    Console.WriteLine(employee2.Name);
                                    flag = 1;

                                }

                            }
                            if (flag == 0)
                                Console.WriteLine("Not found");
                            Console.ReadKey();
                            break;

                        }
               }
                Console.ReadKey();
            }
        }
    }
    public class Employee
    {
        private string id;
        private string name;
        private string area;
        private string city;
        private int pin;
        
       
        public string Id
        {
            get {return id;}
            set{id = value;}
        }
        public string Name
        {
            get{return name;}
            set{name = value;}
        }
        public string Area
        {
            get{return area;}
            set{area = value;}
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public void Register()
        {
            Console.WriteLine("\n Id");
            Id = Console.ReadLine();
            Console.WriteLine("name");
            Name = Console.ReadLine();
            Console.WriteLine("area");
            Area = Console.ReadLine();
            Console.WriteLine("City");
            City = Console.ReadLine();
            Console.WriteLine("Pincode");
            Pin = Convert.ToInt32(Console.ReadLine());

        }

        public void Display(List<Employee>list)
        {
            foreach(Employee employee in list)
            {
                Console.WriteLine("\nThe number of employees in list are :");
                Console.WriteLine(list.Count);
                employee.Display();
            }
        }
        public void Display()
        {
           
            Console.WriteLine("Employee details \n ID : {0} \n Name : {1} \n area {2}\n City :{3} \n Pin :{4} ", Id, Name,Area,City,Pin);

        }
        
        }
        
    }

   


