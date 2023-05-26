namespace CompilerErrors.CS7036
{
    public static class MyClass
    {
        public static int MyMethod()
        {
            return ReturnInt(intParameter: 15);
        }

        public static int ReturnInt(int intParameter)
        {
            return intParameter;
        }
    }
}
