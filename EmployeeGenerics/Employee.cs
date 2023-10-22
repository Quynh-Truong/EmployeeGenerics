using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeGenerics
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private string _gender;
        private int _salary;

        public Employee(int id, string name, string gender, int salary)
        {
            _id = id;
            _name = name;
            _gender = gender;
            _salary = salary;
        }

        public int ID { get { return _id; } }
        public string Name { get { return _name; } }
        public string Gender { get { return _gender; } }
        public int Salary { get { return _salary; } }


    }
}
