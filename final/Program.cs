﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public interface IEmployee //defining interface (use of abstraction)
    {
        
        void Display(List<Employee> list); //abstract method
        void Find(List<Employee> list,string IdToFind); //abstract method

    }
    class Program
    {
        static string id, name, city, email, skype, idToFind, idToUpdate;
        static void Main(string[] args)
        {
            int choice;
          //  string id,name,city,email,skype;
           
            List<Employee> list = new List<Employee>(); //creating list to store the employees

            while(true)
            {
                Console.Clear();
                Console.WriteLine("\n 0.Exit \n 1.Register Employee\n 2.Register Hr \n 3.Register Developer \n 4.Find \n 5.Update \n 6.Display Whole List");
                Console.WriteLine("enter your choice\n");
                choice = Convert.ToInt32(Console.ReadLine());

                Employee employee = new Employee(); //creating an object of employee class
                Program objProgram = new Program();

                switch(choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        objProgram.Register();
                        Console.WriteLine("\n Employee Registered");
                        list.Add(new Employee(id,name,city));
                        Console.ReadKey();
                        break;
                    case 2:
                        objProgram.Register();
                        Console.WriteLine("\n Email :");
                        email = Console.ReadLine();
                        Console.WriteLine("\n Hr Registered");
                        list.Add(new Hr(id,name,city,email));
                        Console.ReadKey();
                        break;
                    
                    case 3:
             
                        objProgram.Register();
                        Console.WriteLine("\n Skype Address :");
                        skype = Console.ReadLine();
                        Console.WriteLine("\n Developer Registered");
                        list.Add(new Developer(id,name,city,skype));
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("\n Enter the id to find");
                        idToFind = Console.ReadLine();
                        employee.Find(list,idToFind);
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("\n Enter the id to update");
                        idToUpdate = Console.ReadLine();
                         foreach (Employee employee3 in list)
                           {
                              if (employee3.Id == idToUpdate)
                               {
                                   Console.WriteLine("\n Id:");
                                   employee3.Id = Console.ReadLine();
                                   Console.WriteLine("\n Name:");
                                   employee3.Name = Console.ReadLine();
                                   Console.WriteLine("\n City :");
                                   employee3.City = Console.ReadLine();
                                   Console.WriteLine("\nIf HR provide the updated email else ignore");
                                   Console.WriteLine("\n Email :");
                                   email = Console.ReadLine();
                                   Console.WriteLine("\nIf Developer provide the updated Skype Address else ignore");
                                   Console.WriteLine("\n Skype Address :");
                                   skype = Console.ReadLine();    
                                }
                            }                           
                        break;
                
                    case 6:
                        Console.WriteLine("\nThe number of employees in list are :");
                        Console.WriteLine(list.Count);
                        employee.Display(list);
                        Console.ReadKey();
                        break;
                }
            }
            
        }

        public void Register()
        {
            Console.WriteLine("\n Id:");
            id = Console.ReadLine();
            Console.WriteLine("\n Name:");
            name = Console.ReadLine();
            Console.WriteLine("\n City :");
            city = Console.ReadLine();
        }
    }

   
        
}

