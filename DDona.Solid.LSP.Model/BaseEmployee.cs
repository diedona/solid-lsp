using DDona.Solid.LSP.Model.Specialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.LSP.Model
{
    public abstract class BaseEmployee : IBaseEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract string DoWork();

        public virtual string GetFullName()
        {
            return string.Concat(this.FirstName, " ", this.LastName);
        }
    }
}
