using System.Reflection;
using MyUnit.Attributes;

namespace MyUnit
{
    public static class MyTestRunner
    {
        public static void RunForType(Type type, Action<string> printResult)
        {
            var methods = GetMethodsForTypeByAttribute(type);

            if (methods.Any())
            {
                var instance = Activator.CreateInstance(type);

                foreach (var method in methods)
                {
                    var data = GetCustomAttributeByAttributeMethod(method);
                    foreach (var item in data)
                    {
                        method.Invoke(instance, item.Args);

                        var methodName = method.Name;

                        if (!MyAssert.AssertWasInvoked)
                            throw new InvalidOperationException($"{methodName} не содержит проверок");

                        printResult?.Invoke(MyAssert.LastRunWasSuccessful
                            ? $"{methodName}: прошёл"
                            : $"{methodName}: провален");

                        MyAssert.ClearLastRunResult();
                    }
                   
                }
            }
        }

        private static IEnumerable<MethodInfo> GetMethodsForTypeByAttribute(Type type)
        {
            var methods = type
                .GetMethods()
                .Where(
                    o => o.GetCustomAttribute<MyFactAttribute>() != null ||
                    o.GetCustomAttribute<MyTheoryAttribute>() != null
                )
                .ToArray();

            return methods;
        }

        private static IEnumerable<MyInlineDataAttribute> GetCustomAttributeByAttributeMethod(MethodInfo method)
        {
            return method.GetCustomAttribute<MyFactAttribute>() !=null ?
                new List<MyInlineDataAttribute>() { new MyInlineDataAttribute() } : 
                method.GetCustomAttributes<MyInlineDataAttribute>();
        }
    }
}
