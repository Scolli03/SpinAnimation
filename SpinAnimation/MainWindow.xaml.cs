using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace SpinAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new VM();
            this.DataContext = vm;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            vm.AngleValue = rnd.Next(360,3600);
        }

        class VM : INotifyPropertyChanged
        {
            private int angleValue;
            public int AngleValue
            {
                get
                {
                    return this.angleValue;
                }
                set
                {
                    this.angleValue = value;
                    RaisePropertyChanged("AngleValue");
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
            void RaisePropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}
