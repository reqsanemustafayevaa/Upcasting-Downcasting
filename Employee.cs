using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskk
{
    public class Employee:Iperson
    {
        public static int ID=0;
        private int _id { get; }
        public static string Name {  get; set; }
        public byte Age { get; set; }
        public double salary {  get; set; }
        public string departmentName {  get; set; }
        public Position Position { get; set; }

        public Employee()
        {
            ID++;
            _id = ID;
            Name = Name;
            Age = Age;
            salary = salary;

        }

        void Iperson.ShowInfo()
        {
            Console.WriteLine($"{ID} {Name} {Age} {salary} {departmentName}");
        }

        

        string Iperson.GetInfo()
        {
            return $"{ID} {Name} {Age} {salary} {departmentName}";
        }
    }
      
       
    
}
