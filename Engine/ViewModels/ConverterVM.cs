using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class ConverterVM
    {
        public StringInput Reverser { get; set; }

        public ConverterVM()
        {
            Reverser = new StringInput();
            Reverser.UserInput = "";
            Reverser.UserOutput = "";

        }

        public void ReverseString()
        {
            List<char> input_chars = new List<char>();

            foreach (char c in Reverser.UserInput )
            {
                input_chars.Add(c);
            }

            input_chars.Reverse();

            string reversed_string = string.Join("", input_chars.ToArray());

            Reverser.UserOutput = reversed_string;
        }
    }
}
