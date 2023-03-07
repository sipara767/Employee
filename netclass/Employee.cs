using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netclass
{
    public class Employee
    {
        private int EmployeeId { get; set; }
        private string EmployeeName { get; set; }
        public DateTime Dateofjoin { get; set; }
        private int Ctc { get; set; } 
        private int Department { get; set; }

        
        public Employee()
        {

        }
        public Employee(int id, string name, DateTime joindate, int ct, int dep)
        {
            EmployeeId = id;
            EmployeeName = name;
            Dateofjoin = new DateTime();
            Ctc = ct;
            Department = dep;
        }
        public void Display()
        {
            Console.WriteLine("Employe Id: {0}",EmployeeId);
            Console.WriteLine("EmployeeName: { 0}", EmployeeName);
            Console.WriteLine("DateOfjoin: {0}", Dateofjoin.ToShortDateString());
            Console.WriteLine("CTC:{}" , Ctc);
            Console.WriteLine("Department: {0}", Department);
        }
    }

    
}

