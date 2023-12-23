using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldIndo(string className, params string[] fields)
        {
            StringBuilder sb = new();
            Type classType = Type.GetType(className);
            FieldInfo[] currentFields = classType.GetFields((BindingFlags)60);

            var hacker = Activator.CreateInstance(classType);

            sb.AppendLine($"Class under investigation: {classType.FullName}");


            foreach (var field in currentFields)
            {
                if (fields.Contains(field.Name))
                {
                    sb.AppendLine($"{field.Name} = {field.GetValue(hacker)}");
                }
            }

            return sb.ToString().Trim();
        }
    }
}
