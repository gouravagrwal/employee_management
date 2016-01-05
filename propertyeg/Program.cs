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
           
            int n, flag=0;

            List<Employee> list = new List<Employee>();
           

            while (true)
            {

                Console.WriteLine("\n0.Exit \n 1.Register \n 2.Find \n 3.Display \n 4.Send message");
                n = Convert.ToInt32(Console.ReadLine());

                Employee emp = new Employee();

                switch (n)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        emp.register();
                        list.Add(emp);
                        Console.WriteLine("Employee Registered\n");
                        emp.display();
                        break;

                    case 2:
                        Console.WriteLine("Enter the id of the employee to find");
                        string w = Console.ReadLine();

                        foreach(Employee e in list)
                        {
                            if (e.Id == w)
                            {
                                Console.WriteLine("the employee is:\n");
                                e.display();
                                flag = 1;

                            }
                           
                        }
                        if(flag==0)
                        Console.WriteLine("Not found");
                        Console.ReadKey();
                        break;

                    case 3:
                        {
                            emp.display(list);
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine("Enter the id of the employee to send message");
                            string y = Console.ReadLine();

                            foreach (Employee e in list)
                            {
                                if (e.Id == y)
                                {
                                    Console.WriteLine("\nthe message is send to:\t");
                                    Console.WriteLine(e.Name);
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

        public void register()
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

        public void display(List<Employee>list)
        {
            foreach(Employee emp in list)
            {
                Console.WriteLine("\nThe number of employees in list are :");
                Console.WriteLine(list.Count);
                emp.display();
            }
        }
        public void display()
        {
           
            Console.WriteLine("Employee details \n ID : {0} \n Name : {1} \n area {2}\n City :{3} \n Pin :{4} ", Id, Name,Area,City,Pin);

        }
        
        }
        
    }

   


