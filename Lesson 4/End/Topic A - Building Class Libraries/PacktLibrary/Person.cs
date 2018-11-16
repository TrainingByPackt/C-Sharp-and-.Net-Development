using System;
using System.Collections.Generic;

namespace PacktLibrary
{
    public class Person
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();
    }
}
