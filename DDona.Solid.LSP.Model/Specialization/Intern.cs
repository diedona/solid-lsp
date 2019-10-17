using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.LSP.Model.Specialization
{
    public class Intern : BaseEmployee, IGotResponsible
    {
        public IManager Responsible { get; set; }

        public override string DoWork()
        {
            return "I'm working like an intern!";
        }

        public void SetResponsible(IManager responsible)
        {
            this.Responsible = responsible;
        }
    }
}
