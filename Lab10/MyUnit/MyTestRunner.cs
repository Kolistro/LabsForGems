using System;
using System.Reflection;
using MyUnit.Attributes;

namespace MyUnit
{
    public static class MyTestRunner
    {
        public static void RunForType(Type type, Action<string> printResult)
        {
            var methods = GetMethodsForTypeByAttribute(type);

            if (!methods.Any()) 
                return;

            var instance = Activator.CreateInstance(type);

            foreach (var method in methods)
            {
                var data = GetCustomAttributeByAttributeMethod(method);
                foreach (var item in data)
                {
                    CheckForNumberOfArguments(item, method);
                    CheckForArgumentTypes(item, method);
                    
                    method.Invoke(instance, item.Args);

                    ResultAssert(method.Name, printResult);    
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
            if(method.GetCustomAttribute<MyFactAttribute>() != null)
            {
                return new List<MyInlineDataAttribute>() { new MyInlineDataAttribute() };
            }else if(method.GetCustomAttribute<MyTheoryAttribute>() != null)
            {
                var data = method.GetCustomAttributes<MyInlineDataAttribute>();

                if(data.Count() == 0)
                    throw new InvalidOperationException("Отсутствует аргумент MyInlineData");

                return method.GetCustomAttributes<MyInlineDataAttribute>();
            }
            throw new InvalidOperationException($"{method.Name} не содержит атрибутов");
        }

        private static void CheckForNumberOfArguments(MyInlineDataAttribute inlineDataAttribute, MethodInfo method)
        {
            if (inlineDataAttribute.Args.Length != method.GetParameters().Length)
                throw new ArgumentException($"Кол-во аргументов тестовых данных и вызываемого метода не соответствуют " +
                    $"{inlineDataAttribute.Args.Length} != {method.GetParameters().Length}");
        }

        private static void CheckForArgumentTypes(MyInlineDataAttribute inlineDataAttribute, MethodInfo method)
        {
            for (int i = 0; i < inlineDataAttribute.Args.Length; i++)
                if (inlineDataAttribute.Args[i].GetType() != method.GetParameters()[i].ParameterType)
                    throw new ArgumentException($"Типы аргументов тестовых данных и вызываемого метода не соответствуют " +
                        $"{inlineDataAttribute.Args[i].GetType()} != {method.GetParameters()[i].ParameterType}");

        }

        private static void ResultAssert(string methodName, Action<string> printResult)
        {
            if (!MyAssert.AssertWasInvoked)
                throw new InvalidOperationException($"{methodName} не содержит проверок");

            printResult?.Invoke(MyAssert.LastRunWasSuccessful
                ? $"{methodName}: прошёл"
                : $"{methodName}: провален");

            MyAssert.ClearLastRunResult();
        }
    }
}
