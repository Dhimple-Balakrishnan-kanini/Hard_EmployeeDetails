using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hard_EmployeeDetails
{
    class EmployeePromotion
    {
        Employee emp = new Employee();                        
        List<Employee> employees = new List<Employee>();    

        //Creating method to add the details of employee
        public void AddEmployee()                             
        {
            int num = 1;

            while (num == 1)
            {

                emp.TakeEmployeeDetailsFromUser();
                employees.Add(new Employee() { Id = emp.Id, Name = emp.Name, Age = emp.Age, Salary = emp.Salary });
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                num = Convert.ToInt32(Console.ReadLine());

            }

        }

        //Creating method Print the details of all employees
        public void PrintAllEmployees()    
        {
            foreach (var element in employees)
            {
                Console.WriteLine(element);
            }

        }

        //creating method to modify the details of employee
        public void ModifyEmployee(int EmpID, string updatedempname, int updatedempage, double updatedempsalary) 
        {
            var modify = employees.Where(e => e.Id == EmpID);
            foreach (var element in modify)
            {

                element.Name = updatedempname;
                element.Age = updatedempage;
                element.Salary = updatedempsalary;

            }


        }

        // creating method to print the details of an employee
        public List<Employee> PrintAnEmployeeDetail(int EmpId, List<Employee> emplist)   
        {
            return emplist.Where(e => e.Id == EmpId).ToList();

        }
        public void DisplayMenu()
        {
            bool value = true;
            while (value == true)
            {
                Console.WriteLine("Please enter the option");
                Console.WriteLine("1.Add an employee");
                Console.WriteLine("2. Modify an employee detail");
                Console.WriteLine("3. Print all employee's details");
                Console.WriteLine("4.Print an employee detail");
                Console.WriteLine("5.Exit");

                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;

                    case 2:
                        Console.WriteLine("Please enter the employee ID");
                        int Empid = Convert.ToInt32(Console.ReadLine());
                        var employeedata = PrintAnEmployeeDetail(Empid, employees);
                        employeedata.ForEach(x => Console.WriteLine(x + " "));
                        Console.WriteLine("Please enter the updated employee details");
                        Console.WriteLine("Please enter the employee name");
                        string updatedempname = Console.ReadLine();
                        Console.WriteLine("Please enter the employee age");
                        int updatedempage = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the employee salary");
                        double updatedempsalary = Convert.ToDouble(Console.ReadLine());

                        ModifyEmployee(Empid, updatedempname, updatedempage, updatedempsalary);
                        break;
                    case 3:
                        PrintAllEmployees();
                        break;
                    case 4:
                        Console.WriteLine("Please enter the employee ID");
                        int EmpId = Convert.ToInt32(Console.ReadLine());
                        var empdata = PrintAnEmployeeDetail(EmpId, employees);
                        empdata.ForEach(x => Console.WriteLine(x + " "));
                        break;
                    case 5:
                        value = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
        }



        static void Main(string[] args)
        {
            EmployeePromotion p1 = new EmployeePromotion();
            p1.DisplayMenu();


        }




    }
}
