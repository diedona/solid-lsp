namespace DDona.Solid.LSP.Model.Specialization
{
    internal interface ICeo : IBaseEmployee, IPaidEmployee
    {
        double SalaryMultiplier { get; set; }
    }
}