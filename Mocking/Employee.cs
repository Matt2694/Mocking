using System;
using System.Collections.Generic;

namespace Mocking
{
    public class Employee
    {
        public int Id { get; internal set; }
        public MailBox MailBox { get; internal set; }
        public string Name { get; internal set; }
        public string Type { get; internal set; }
        public double Wage { get; internal set; }

        internal double CalculateWeeklySalary(double hours, double wage, User user)
        {
            if (user.Rights.Equals(Right.Full))
            {
                return (hours * wage);
            }
            else
            {
                throw new Exception("You do not have access to that feature.");
            }
            
        }
        internal double CalculateWeeklySalary(double hours, double wage)
        {
            return (hours * wage);
        }

        internal double CalculateAverageSalary(List<double> salaries, User user)
        {
            double total = 0;
            if (user.Rights.Equals(Right.Full))
            {
                foreach (double salary in salaries)
                {
                    total += salary;
                }
                return total / salaries.Count;
            }
            else
            {
                throw new Exception("You do not have access to that feature.");
            }
        }
        internal double CalculateAverageSalary(List<double> salaries)
        {
            double total = 0;

            foreach (double salary in salaries)
            {
                total += salary;
            }
            return total / salaries.Count;

        }
    }
}