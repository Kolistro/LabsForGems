namespace MyUnit
{
    public static class MyAssert
    {
        internal static bool LastRunWasSuccessful { get; private set; }
        internal static bool AssertWasInvoked{ get; private set; }

        public static void Equal(object expected, object sample)
        {
            LastRunWasSuccessful = expected.Equals(sample);
            AssertWasInvoked = true;
        }

        public static void Throws<T> (Func<Object> func) where T : Exception
        {
            try
            {
                func.Invoke();
                LastRunWasSuccessful = false;
            }
            catch
            {
                LastRunWasSuccessful = true;
            }
            finally
            {
                AssertWasInvoked = true;
            }

        }

        internal static void ClearLastRunResult()
        {
            LastRunWasSuccessful = false;
            AssertWasInvoked = false;
        }
    }
}
