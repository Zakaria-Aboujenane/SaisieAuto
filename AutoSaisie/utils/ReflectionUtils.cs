using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaisie.utils
{
    class ReflectionUtils
    {
        public static IEnumerable<Type> getDerivedTypesFor(Type baseType)
        {
            var assembly = Assembly.GetExecutingAssembly();

            return assembly.GetTypes()
                .Where(baseType.IsAssignableFrom)
                .Where(t => baseType != t);
        }
        public static object createInstance(string className)
        {
            var assembly = Assembly.GetExecutingAssembly();
            try
            {
                var type = assembly.GetTypes()
                    .First(t => t.Name == className);
                return Activator.CreateInstance(type);
            }
            catch(Exception e)
            {
                return null;
            }

           
        }
    }
}
