using System;
using System.Collections.Generic;
using System.Text;

namespace Laegehuset
{
    public class Person : Entity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }

    public class Patient : Person { }

    public class Doctor : Person { }
}
