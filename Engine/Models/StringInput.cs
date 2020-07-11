using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class StringInput : INotifyPropertyChanged
    {
        private string _getUserInput;

        public string UserInput
        {
            get { return _getUserInput; }
            set
            {
                UserInput = value;
                OnPropertyChanged("UserInput");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
