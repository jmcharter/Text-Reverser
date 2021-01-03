using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Engine.ViewModels;

namespace Text_Reverser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ConverterVM _converterVM;
        public MainWindow()
        {
            InitializeComponent();

            _converterVM = new ConverterVM();
            DataContext = _converterVM;

        }

        private void Reverse_Click(object sender, RoutedEventArgs e)
        {
            _converterVM.ReverseString();
        }

        private void TextBox_KeyEnter(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                
                _converterVM.ReverseString();
            }
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {

            string_out.SelectAll();
            string_out.Copy();


        }
    }
}
