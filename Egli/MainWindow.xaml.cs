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

namespace Egli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        /// <summary>
        /// https://www.netcontrol.com/services/radio-networking-tools/egli-calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void oncalc(object sender, RoutedEventArgs e)
        {
            double f = double.Parse(freq.Text);
            double txh = double.Parse(txheight.Text);
            double rxh = double.Parse(rxheight.Text);
            double dist = double.Parse(distance.Text );

            double mtof = 3.28084;

            double att = 117 + (40 * Math.Log10(dist)) + (20 * Math.Log10(f)) - (20*Math.Log10(mtof * mtof * txh*rxh));

            attenuation.Text = att.ToString();

        }
    }
}
