using System;
using ValidationAttributes.Models;
using ValidationAttributes.Utils;

namespace ValidationAttributes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var person = new Person
             (
                 null,
                 -1
             );

            var cat = new Cat
                (
                    "Grisho",
                    12
                );

            var secondCat = new Cat
                (
                    null,
                    0
                );

            bool isValidPerson = Validator.IsValid(person);
            bool isValidCat = Validator.IsValid(cat);
            bool isValidSecondCat = Validator.IsValid(secondCat);

            Console.WriteLine($"Is Person Valid -> {isValidPerson}");
            Console.WriteLine($"Is Cat Valid -> {isValidCat}");
            Console.WriteLine($"Is SecondCat Valid -> {isValidSecondCat}");
        }
    }
}