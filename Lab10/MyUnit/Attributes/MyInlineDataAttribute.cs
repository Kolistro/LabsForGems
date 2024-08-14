namespace MyUnit.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class MyInlineDataAttribute : Attribute
    {
        public object[] Args { get; }

        public MyInlineDataAttribute(params object[] args) {
            Args = args;
        }
    }
}
