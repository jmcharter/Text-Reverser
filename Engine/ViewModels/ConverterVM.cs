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
            Reverser.UserInput = "Type here...";
            Reverser.UserOutput = "";

        }
    }
}
