using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.LSP.Model.Specialization
{
    public class Employee : BaseEmployee, IPaidEmployee, IGotResponsible
    {
        public int WorkHours { get; set; }
        public double HourRate { get; set; }
        public IManager Responsible { get; set; }

        public double CalculateSalary()
        {
            return (this.WorkHours * this.HourRate);
        }

        public override string DoWork()
        {
            return "Working as an average employee...";
        }

        public void SetResponsible(IManager responsible)
        {
            this.Responsible = responsible;
        }
    }
}
