using System;
namespace StacksQueues
{
    public class StacksQueues
    {
        public StacksQueues()
        {
        }


        private static bool IsOpenDelimiter(char ch)
        {
            return ch == '(' || ch == '[' || ch == '{';
        }

        private static bool IsCloseDelimiter(char ch)
        {
            return ch == ')' || ch == ']' || ch == '}';
        }

        private static bool IsPaired(char open, char close)
        {
            return (open == '(' && close == ')') || (open == '[' && close == ']') || (open == '{' && close == '}');
        }

    }
}
