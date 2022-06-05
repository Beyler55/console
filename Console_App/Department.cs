using System;
namespace Console_App
{
    class Department
    {
        public string DepartmentName { get; set; }
        public int EmployeeLimit { get; set; }
        public int Budget { get; set; }
        public Employee[] employees;
        public int RequiredExperience { get; set; }
        public bool IsBachelorDegreeRequired { get; set; }

        public Department()
        {

        }

        public Department(string name, int limit, int experience, bool bachdegree, int budget):this()
        {
            DepartmentName = name;
            EmployeeLimit = limit;
            Budget = budget;
            RequiredExperience = experience;
            IsBachelorDegreeRequired = bachdegree;
            employees = new Employee[0];
        }


        public bool AddEmployee(Employee employee)
        {
            int totalempsalary = 0;
            if (employee.EmpExperience >= RequiredExperience && employee.HasBachelorDegree == IsBachelorDegreeRequired)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
                foreach (var item in employees)
                {

                    totalempsalary = totalempsalary + employee.EmpSalary;
                }

                if (employees.Length < EmployeeLimit && totalempsalary <= Budget)
                {
                    return true;
                }
            }
            return false;
        }
        
        public void Average()
        {
            int sum = 0;
            foreach (var item in employees)
            {
                sum += item.EmpSalary;
            }
            double Average = sum / employees.Length;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("YOUR AVERAGE SALARY : " + Average);
        }
    }
}
