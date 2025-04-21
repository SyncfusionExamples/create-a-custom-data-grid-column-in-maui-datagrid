using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridSample
{   

    public class Employee
    {
        private int _EmployeeID;
        private string _Name;
        private long _NationalIDNumber;
        private int _ContactID;
        private string _LoginID;
        private int _ManagerID;
        private string _Title;
        private DateTime _BirthDate;
        private string _MaritalStatus;
        private string _Gender;
        private DateTime _HireDate;
        private int _SickLeaveHours;
        private double _Salary;
        private bool employeeStatus;
        private int _rating;

        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public long IDNumber { get; set; }
        public string Title { get; set; }
        public int ContactID { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public int SickLeaveHours { get; set; }
        public double Salary { get; set; }
        public string LoginID { get; set; }
        public int ManagerID { get; set; }
        public bool EmployeeStatus { get; set; }
        public int Rating { get; set; }
    }

}
