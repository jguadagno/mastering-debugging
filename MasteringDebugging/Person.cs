using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MasteringDebugging
{
    [DebuggerDisplay("{FullName}, DOB Time {DateOfBirth.Minute}, number of children = '{Children.Count}'")]
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Person> Children { get; set; }

        public string FullName
        {
            get
            {
                return string.IsNullOrEmpty(MiddleInitial)
                    ? string.Format("{0} {1}", FirstName, LastName)
                    : string.Format("{0} {1}. {2}", FirstName, MiddleInitial, LastName);
            }
        }
    }
}
