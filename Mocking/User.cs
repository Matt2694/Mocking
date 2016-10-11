using System;

namespace Mocking
{
    public class User
    {
        //public enum Rights
        //{
        //    Full, None, Partial
        //}
        public User()
        {
        }

        public int NumMessagesCreated { get; internal set; }
        public string Password { get; set; }
        public object Rights { get; internal set; }
        public string UserName { get; set; }

        internal string ViewAllEmployees()
        {
            return "Here is the list";
        }

        internal void EditEmployeeName(Employee employee, string newName)
        {
            if (Rights.Equals(Right.Full))
            {
                employee.Name = newName;
            }
            else
            {
                throw new Exception("You do not have access to that feature.");
            }
        }

        internal void EditEmployeeWage(Employee employee, double newWage)
        {
            if (Rights.Equals(Right.Full))
            {
                employee.Wage = newWage;
            }
            else
            {
                throw new Exception("You do not have access to that feature.");
            }
        }
    }
}