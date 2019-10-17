using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.LSP.Model.Specialization
{
    public interface IGotResponsible
    {
        IManager Responsible { get; set; }

        void SetResponsible(IManager responsible);
    }
}
