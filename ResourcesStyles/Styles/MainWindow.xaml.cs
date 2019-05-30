using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Styles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*
            Setter mySetter = new Setter();
            mySetter.Property = Control.BackgroundProperty;
            mySetter.Value = new SolidColorBrush(Colors.GreenYellow);

            Style myStyle = new Style();
            */


            //myButton.Background = new SolidColorBrush(Colors.Aquamarine);
            //myButton.Background = new LinearGradientBrush(Colors.Beige, Colors.Blue, 0);

        }
    }
}
