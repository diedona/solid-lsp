namespace DDona.Solid.LSP.Model.Specialization
{
    public interface IBaseEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        string GetFullName();
        string DoWork();
    }
}