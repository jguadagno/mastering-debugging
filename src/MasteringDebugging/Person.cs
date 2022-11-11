namespace MasteringDebugging;

#region Hidden for now
[System.Diagnostics.DebuggerDisplay("{FullName}, DOB Time {DateOfBirth.Minute}, number of children = '{Children.Count}'")]
#endregion
public class Person
{
    public string FirstName { get; set; }
    public string MiddleInitial { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    #region Hidden for now
    //[DebuggerBrowsable(DebuggerBrowsableState.Never)]
    #endregion
    public DateTime DateOfBirth { get; set; }
    public List<Person> Children { get; set; }

    public string FullName => string.IsNullOrEmpty(MiddleInitial)
        ? $"{FirstName} {LastName}"
        : $"{FirstName} {MiddleInitial}. {LastName}";
}