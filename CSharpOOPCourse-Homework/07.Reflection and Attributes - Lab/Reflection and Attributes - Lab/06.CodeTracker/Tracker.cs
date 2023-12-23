using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type classType = typeof(StartUp);
            MethodInfo[] methods = classType.GetMethods((BindingFlags)60);

            Type attributeType = typeof(AuthorAttribute);

            foreach (var method in methods)
            {
                if (method.CustomAttributes.Any(x => x.AttributeType == typeof(AuthorAttribute)))
                {
                    var attributes = method.GetCustomAttributes(attributeType);
                    foreach (AuthorAttribute attribute in attributes)
                    { 
                        Console.WriteLine($"{method.Name} written by {attribute.Name}");
                    }
                }
            }
        }
    }
}
