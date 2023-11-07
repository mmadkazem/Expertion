using ConsoleApp1;

namespace ConsoleApp1
{
    public class Expertion
    {
        private MyStack<char> _stack;
        private char[] _openChars = { '(', '<', '[', '{' };
        private char[] _closeChars = { ')', '>', ']', '}' };

        public Expertion()
        {
            _stack = new MyStack<char>();
        }

        public bool isBallance(string txt)
        {
            foreach (char c in txt.ToCharArray())
            {
                if (isOpenChars(c))
                {
                    _stack.Push(c);
                }
                if (isCloseChars(c))
                {
                    if (_stack.IsEmpty()) return false;

                    if (Same(c))
                    {
                        _stack.Pop();
                    }
                }
            }
            return _stack.IsEmpty();
        }

        private bool isOpenChars(char c)
        {
            foreach (char item in _openChars)
            {
                if (item == c) return true;
            }
            return false;
        }

        private bool isCloseChars(char c)
        {
            foreach (char item in _closeChars)
            {
                if (item == c) return true;
            }
            return false;
        }
        private bool Same(char c)
        {
            return (_stack.Peep() == '(' && c == ')') ||
                (_stack.Peep() == '{' && c == '}') ||
                (_stack.Peep() == '<' && c == '>') ||
                (_stack.Peep() == '[' && c == ']');
        }
    }
}
