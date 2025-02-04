using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input
{
    internal class Input
    {
        public string InputString(string input) 
        {
            for (int i = 0; i < input.Length; i++)
            {
                Thread.Sleep(50);
                Console.Write(input[i]);
            }
            return input;
        }
    }
}
