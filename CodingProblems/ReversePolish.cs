using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class ReversePolish
    {
        private static readonly Dictionary<char, bool> _Operations = new Dictionary<char, bool>() { { '+', true }, { '-', true}, { '*', true }, { '/', true } };

        public int Calculate(char[] values)
        {
            var numbers = new Stack<int>();

            for(int i = 0; i < values.Length; i++)
            {
                if (!_Operations.ContainsKey(values[i]))
                    numbers.Push(values[i]);
                else
                {
                    int a = numbers.Pop();
                    int b = numbers.Pop();
                    int calculated = Operate(b, a, values[i]);
                 
                    numbers.Push(calculated);
                }
            }
            return numbers.Pop();
        }

        public int Operate(int a, int b, char operation)
        {
            int value = 0;

            if(operation == '*')
                value = a * b;
            else if (operation == '+')
                value = a + b;
            else if (operation == '-')
                value = a - b;
            else if (operation == '/')
                value = a / b;

            return value;
        }
    }
}
