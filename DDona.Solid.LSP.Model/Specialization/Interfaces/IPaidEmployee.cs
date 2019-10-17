using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.LSP.Model.Specialization
{
    public interface IPaidEmployee : IBaseEmployee
    {
        int WorkHours { get; set; }
        double HourRate { get; set; }
        double CalculateSalary();
    }
}
