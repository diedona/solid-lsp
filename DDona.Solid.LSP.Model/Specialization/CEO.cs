using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.LSP.Model.Specialization
{
    public class CEO : BaseEmployee, ICeo
    {
        public double SalaryMultiplier { get; set; }
        public int WorkHours { get; set; }
        public double HourRate { get; set; }

        public double CalculateSalary()
        {
            return ((this.WorkHours * this.HourRate) * this.SalaryMultiplier);
        }

        public override string DoWork()
        {
            return "This business is mine.";
        }
    }
}
