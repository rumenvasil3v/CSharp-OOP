using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
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

        public string AnalyzeAccessModifiers(string className)
        {
            StringBuilder sb = new();
            Type classType = Type.GetType(className);
            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public);
            PropertyInfo[] properties = classType.GetProperties((BindingFlags)60);

            foreach (var field in fields.Where(x => x.Name != "BackingField"))
            {
                if (field.IsPublic)
                {
                    sb.AppendLine($"{field.Name} must be private!");
                }
            }

            foreach (PropertyInfo property in properties)
            {
                MethodInfo setMethod = property.GetSetMethod(true);
                MethodInfo getMethod = property.GetGetMethod(true);

                if (setMethod.IsPublic)
                {
                    sb.AppendLine($"{property.SetMethod.Name} have to be private!");
                }

                if (getMethod.IsPrivate)
                {
                    sb.AppendLine($"{property.GetMethod.Name} have to be public!");
                }
            }

            return sb.ToString().Trim();
        }
    }
}