using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23GangOfFourDesignPatterns.Utilities.CustomAttributes
{
    public static class AttributeHelper
    {
        /// <summary>
        /// Generic method that targets custom attribute on class by type, using a Linq expression which has a parameter of type TAttribute to access the properties of the Attribute on the class.
        /// </summary>
        /// <typeparam name="TAttribute">The attribute on the class with the desired property</typeparam>
        /// <typeparam name="TValue">The type of the variable that is being returned.</typeparam>
        /// <param name="type">The class type that the attribute is stored against. This method make use of the GetCustomAttributes Inherit property, which allows for attributes on concrete implementations to be derived from the bass class.</param>
        /// <param name="valueSelector">A Linq Expression that targets the attributes defined on the TAttribute being targeted as a typeParam</param>
        /// <returns>The value of the propery being targeted on the Attribute. </returns>
        public static TValue GetAttributeValue<TAttribute, TValue>(this Type type,Func<TAttribute, TValue> valueSelector) where TAttribute : Attribute
        {
            var att = type.GetCustomAttributes(typeof(TAttribute), true).FirstOrDefault() as TAttribute;

            if (att != null)
            {
                return valueSelector(att);
            }
            return default(TValue);
        }
    }
}
