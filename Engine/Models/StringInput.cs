using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class StringInput : INotifyPropertyChanged
    {
        private string _getUserInput;
        private string _getUserOutput;

        public string UserInput
        {
            get { return _getUserInput; }
            set
            {
                _getUserInput = value;
                OnPropertyChanged("UserInput");
            }
        }
        public string UserOutput
        {
            get { return _getUserOutput; }
            set
            {
                _getUserOutput = value;
                OnPropertyChanged("UserOutput");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
