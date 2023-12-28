using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models
{
    public class Person
    {
        private string fullName;
        private int age;

        public Person(string fullName, int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }

        [MyRequired]
        public string FullName { get { return fullName; } set { fullName = value; } }

        [MyRange(12, 90)]
        public int Age { get { return age; } set { age = value; } }
    }
}