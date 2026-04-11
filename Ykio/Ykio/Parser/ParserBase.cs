using System.Reflection;

namespace Ykio.Parser
{
    public class ParseBase
    {

    }
    public class ParserAtribyte(string SourceType) : Attribute
    {
        
    }
    public class ParseFinder
    {
        public Type Find(string type)
        {
            var t = FindParseClass(typeof(ParseBase), typeof(ParserAtribyte));

            return t.First();
        }
        static List<Type> FindParseClass(Type parseBaseType, Type attributeType)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();

            foreach (var assembly in assemblies)
            {
                try
                {
                    var matchingTypes = assembly.GetTypes()
                        .Where(type => type != parseBaseType &&
                                      parseBaseType.IsAssignableFrom(type) &&
                                      Attribute.IsDefined(type, attributeType))
                        .ToList();

                    if (matchingTypes.Any())
                    {
                        return matchingTypes;
                    }
                }
                catch (ReflectionTypeLoadException)
                {
                    continue;
                }
            }

            return null;
        }
    }
}
