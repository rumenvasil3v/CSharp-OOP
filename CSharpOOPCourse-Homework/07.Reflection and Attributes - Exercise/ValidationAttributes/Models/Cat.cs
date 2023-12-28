using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models
{
    public class Cat
    {
        private string breed;
        private int age;

        public Cat(string breed, int age)
        {
            this.Breed = breed;
            this.Age = age;
        }

        [MyRequired]
        public string Breed { get { return breed; } set { breed = value; } }

        [MyRange(1, 15)]
        public int Age { get { return age; } set { age = value; } }
    }
}