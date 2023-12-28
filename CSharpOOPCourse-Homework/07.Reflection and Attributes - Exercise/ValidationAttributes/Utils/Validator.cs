using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ValidationAttributes.Attributes;
using ValidationAttributes.Models;

namespace ValidationAttributes.Utils
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            Type type = obj.GetType();

            PropertyInfo[] myProperties = type.GetProperties((BindingFlags)60);

            foreach (PropertyInfo propertyInfo in myProperties)
            {
                var customAttributes = propertyInfo.GetCustomAttributes();

                foreach (MyValidationAttribute myValidationAttribute in customAttributes)
                {
                    if (!myValidationAttribute.IsValid(propertyInfo.GetValue(obj)))
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }
    }
}