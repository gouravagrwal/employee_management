using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public interface IEmployee
    {
    
        void Display(List<Employee> list);
        void Find(List<Employee> list);

    }
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            string id,name,city,email,skype;
           
            List<Employee> list = new List<Employee>();

            while(true)
            {
                Console.Clear();
                Console.WriteLine("\n 0.Exit \n 1.Register Employee\n 2.Register Hr \n 3.Register Developer \n 4.Find \n 5.Display Whole List");
                Console.WriteLine("enter your choice\n");
                choice = Convert.ToInt32(Console.ReadLine());

                Employee employee = new Employee();


                switch(choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("\n Id:");
                        id = Console.ReadLine();
                        Console.WriteLine("\n Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("\n City :");
                        city = Console.ReadLine();
                        Console.WriteLine("\n Employee Registered");
                        list.Add(new Employee(id,name,city));
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\n Id:");
                        id = Console.ReadLine();
                        Console.WriteLine("\n Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("\n City :");
                        city = Console.ReadLine();
                        Console.WriteLine("\n Email :");
                        email = Console.ReadLine();
                        Console.WriteLine("\n Hr Registered");
                        list.Add(new Hr(id,name,city,email));
                        Console.ReadKey();
                        break;
                    
                    case 3:

                        Console.WriteLine("\n Id:");
                        id = Console.ReadLine();
                        Console.WriteLine("\n Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("\n City :");
                        city = Console.ReadLine();
                        Console.WriteLine("\n Skype Address :");
                        skype = Console.ReadLine();
                        Console.WriteLine("\n Developer Registered");
                        list.Add(new Developer(id,name,city,skype));
                        Console.ReadKey();
                        break;

                    case 4:
                        employee.Find(list);
                        Console.ReadKey();
                        break;
                
                    case 5:
                        Console.WriteLine("\nThe number of employees in list are :");
                        Console.WriteLine(list.Count);
                        employee.Display(list);
                        Console.ReadKey();
                        break;
                }
            }
            
        }
    }
        
    }

