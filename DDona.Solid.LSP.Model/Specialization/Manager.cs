using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.LSP.Model.Specialization
{
    public class Manager : BaseEmployee, IManager
    {
        public int WorkHours { get; set; }
        public double HourRate { get; set; }
        public double Bonus { get; set; }

        public double CalculateSalary()
        {
            return ((this.HourRate * this.WorkHours) + this.Bonus);
        }

        public override string DoWork()
        {
            return "I'm managing everything in this house!";
        }
    }
}
