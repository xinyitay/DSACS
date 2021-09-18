using System;
namespace Recursion
{
    public static class Reverse
    {
        public static string ReverseStr(string str, string impl="recursive")
        {
            if (impl != "recursive" && impl != "iterative")
            {
                throw new Exception("Unknown implementation type.");
            }

            if (str.Length == 0)
            {
                return "";
            }

            return (impl == "recursive") ? RReverse(str) : IReverse(str);
        }

        private static string IReverse(string str)
        {
            return "";
        }

        private static string RReverse(string str)
        {
            return "";
        }
    }
}
