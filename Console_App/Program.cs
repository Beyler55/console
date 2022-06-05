using Console_App.Helpers;
using System;
namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Department dep = new Department();
            Helper.Print("Enter department name :", ConsoleColor.Green);
            dep.DepartmentName = Console.ReadLine();

            Helper.Print("Enter max limit of employees in group :", ConsoleColor.Green);
        //int DepLimit = int.Parse(Console.ReadLine());
        isdeplimit:
            //int DepLimit=0;
            string strDepLimit = Console.ReadLine();
            bool isInt = int.TryParse(strDepLimit, out int emplimit);
            dep.EmployeeLimit = emplimit;
            if (!isInt)
            {
                Helper.Print("Daxil et yeniden", ConsoleColor.Red);
                goto isdeplimit;
            }

            Helper.Print("Enter department budget:", ConsoleColor.Green);
        // int DepBudget = int.Parse(Console.ReadLine());

        //int DepBudget = 0;
        isdepbudget:
            string strDepBudget = Console.ReadLine();
            bool isBInt = int.TryParse(strDepBudget, out int DepBudget);
            if (!isBInt)
            {
                Helper.Print("Daxil et yeniden", ConsoleColor.Red);
                goto isdepbudget;
            }
            dep.Budget = DepBudget;
            Helper.Print("Enter required experience year for department employees :", ConsoleColor.Green);
        isdepreq:
           
            string strreqexp = Console.ReadLine();
            bool isRInt = int.TryParse(strreqexp, out int Depreqexp);
            if (!isRInt)
            {
                Helper.Print("Daxil et yeniden", ConsoleColor.Red);
                goto isdepreq;
            }
            dep.RequiredExperience = Depreqexp;
            Helper.Print("Enter required bachelor degree for department : (true/false)", ConsoleColor.Green);
            bool DepBachDeg = bool.Parse(Console.ReadLine());


            string answer = "";
            do
            {
                Employee emp = new Employee();
                Helper.Print("Enter employee name:", ConsoleColor.DarkGreen);
                string EmployeeName = Console.ReadLine();
                emp.EmpName = EmployeeName;
                Helper.Print("Enter employee Surname:", ConsoleColor.DarkGreen);
                string EmployeeSurname = Console.ReadLine();
                emp.EmpSurname = EmployeeSurname;
                Helper.Print("Enter employee salary:", ConsoleColor.DarkGreen);
            isempsal:
                string strEmpSal = Console.ReadLine();
                bool isSInt = int.TryParse(strEmpSal, out int empsal);
                if (!isSInt)
                {
                    Helper.Print("Daxil et yeniden", ConsoleColor.Red);
                    goto isempsal;
                }
                emp.EmpSalary = empsal;
                Helper.Print("Enter employee experience:", ConsoleColor.DarkGreen);
                isempexp:
                string strEmpExp = Console.ReadLine();
                bool isEInt = int.TryParse(strDepBudget, out int empexp);
                if (!isEInt)
                {
                    Helper.Print("Daxil et yeniden", ConsoleColor.Red);
                    goto isempexp;
                }
                emp.EmpExperience = empexp;
                Helper.Print("Enter employee's bachelor degree:", ConsoleColor.DarkGreen);
                bool EmployeeBachdeg = bool.Parse(Console.ReadLine());
                emp.HasBachelorDegree = EmployeeBachdeg;


                dep.AddEmployee(emp);
                Helper.Print("Do you want to add employee?   (y/n)", ConsoleColor.Cyan);
                answer = Console.ReadLine();

            }
            while (answer == "y");

           
            dep.Average();
        }
    }
}
