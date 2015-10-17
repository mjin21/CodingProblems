using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class ReversePolish
    {
        public int Calculate(char[] values)
        {
            Dictionary<char, bool> operations = new Dictionary<char, bool>();
            var numbers = new Stack<int>();

            for(int i = 0; i < values.Length; i++)
            {
                if (!operations.ContainsKey(values[i]))
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
