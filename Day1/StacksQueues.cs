using System;
namespace Day1
{
    public class StacksQueues
    {
        public StacksQueues()
        {
            LinkedList myStack = new LinkedList();
        }

        public void push


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
