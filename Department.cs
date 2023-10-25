using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskk
{
    public class Department
    {
        public string Name { get; set; }
        private int _employeelimit;
        public static int ID = 0;
        private int _id { get; }
        public Department(string name,int employeelmit)
        {
            Name = name;
            EmployeeLimit = employeelmit;
        }
        public Department()
        {
            ID++;
            _id = ID;
        }
        public int EmployeeLimit
        {
            get
            {
                return _employeelimit;
            }
            set
            {
                _employeelimit = value;
            }
        }
        public Employee[] Employees=new Employee[0];
        public void AddEmployee(Employee employee)
        {
            if(Employees.Length<EmployeeLimit)
            {
                Array.Resize(ref Employees, Employees.Length+1);
                Employees[Employees.Length-1] = employee;
            }
            else
            {
                throw new CapasityLimitException("Limit asilmisdir");
            }
        }
        public void AddEmployee(ref Employee[] newemployee,Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }
        public Employee[]GetEmployeeByPosition(string position)
        {
            Employee[] newEmployee = new Employee[0];
           foreach(Employee employee in Employees)
            {
                if (employee.Position == position)
                {
                    AddEmployee(ref newEmployee,employee);
                }
            }
           return newEmployee;
        }
        public Employee[]removeEmployee(int id)
        {
            Employee[]newEmployee= new Employee[0];
            foreach(Employee employee in Employees)
            {
                if (employee.ID != id)
                {
                    AddEmployee(ref newEmployee, employee);
                }
            }
            return newEmployee;
        }
        public int GetEmployee(int id)
        {
            
            foreach (Employee employee in Employees)
            {
                if (employee.ID == id)
                {
                    return employee;
                }
            }
            return 0;
        }
        public Employee[]GetEmployeeBySalary(int minSalary,int maxSalary)
        {
            Employee[]newEmployee= new Employee[0];
            foreach (Employee employee in Employees)
            {
                if(employee.salary > minSalary && employee.salary < maxSalary)
                {
                    AddEmployee(ref newEmployee, employee);
                }
            }
            return newEmployee;
        }
       public Employee[]GetEmployeesByDepartmentName(string departmentName)
        {
            Employee[]newEmployee= new Employee[0];
            foreach (Employee employee in Employees)
            {
                if(employee.departmentName == departmentName)
                {
                    AddEmployee(ref newEmployee, employee);
                }

            }
            return newEmployee;
        }
        public void ShowAllEmployees()
        {
            Console.WriteLine($"{Name} {EmployeeLimit} {ID}");
        }
    }
}
