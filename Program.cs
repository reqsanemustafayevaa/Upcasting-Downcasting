namespace taskk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("department adi axil edin");
            string name=Console.ReadLine();
            
            Department department=new Department();

            int choice;
            do
            {
                Console.WriteLine("choose operation");
                Console.WriteLine("1.employee elave et \n2.isci axtar \n3.butun iscilere bax \n4.maas araligina gore iscileri axtaris et \n5.departmente gore iscileri axtaris et \n5.positiona gore iscileri axtaris et \n9.iscini qov \n0.programi bitir");
                switch(choice)
                {
                    case 1:
                        department.AddEmployee(new Employee());
                        break;
                    case 2:
                        int id=int.Parse(Console.ReadLine());
                        department.GetEmployee(id);
                        break;
                    case 3:
                        department.ShowAllEmployees();
                        break;
                    case 4:
                        Console.WriteLine("minsalary daxil edin");
                        int minsalary=int.Parse(Console.ReadLine());
                        Console.WriteLine("maxsalary daxil edin");
                        int maxsalary=int.Parse(Console.ReadLine());    
                        department.GetEmployeeBySalary(minsalary, maxsalary);
                        break;
                    case 5:
                        Console.WriteLine("department name daxil edin");
                        department.GetEmployeesByDepartmentName(name);
                        break;
                   

                        
                          
                        
                }
            }while (true);


            
        }
    }
}