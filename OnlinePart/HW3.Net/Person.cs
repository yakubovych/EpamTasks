namespace HW3.Net
{
    using System.Collections.Generic;

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public IEnumerable<string> PhoneNumbers { get; set; }
    }
}
