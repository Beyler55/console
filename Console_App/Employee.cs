namespace Console_App
{
    class Employee
    {
        public string EmpName { get; set; }
        public string EmpSurname { get; set; }
        public int EmpSalary { get; set; }
        public int EmpExperience { get; set; }
        public bool HasBachelorDegree { get; set; }
        
        public Employee()
        {

        }

        public Employee(string empname, string empsur, int empsal, int empexp, bool empbachdeg) : this()
        {
            EmpName = empname;
            EmpSurname = empsur;
            EmpSalary = empsal;
            EmpExperience = empexp;
            HasBachelorDegree = empbachdeg;
        }
        public override string ToString()
        {
            return $"{EmpName}---{EmpSurname}";
        }
    }
}
