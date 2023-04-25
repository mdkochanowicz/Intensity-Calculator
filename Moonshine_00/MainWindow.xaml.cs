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

namespace Moonshine_00
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        public MainWindow()
        {
            InitializeComponent();

            Equals.Click += Equals_Click;
        }

        public void AlkoVolume_TextChanged(object sender, TextChangedEventArgs e)
        {
            string typedValueAlko;
            typedValueAlko = sender.ToString();
            //double typedValueDouble;
            //typedValueDouble = Convert.ToDouble(typedValue);

        }

        public void AlkoPercent_TextChanged(object sender, TextChangedEventArgs e)
        {
            string typedValuePercent;
            typedValuePercent = sender.ToString();
        }

        public void AlkoPercentAlready_TextChanged(object sender, TextChangedEventArgs e)
        {
            string typedValuePercentAlready;
            typedValuePercentAlready = sender.ToString();
        }
        
        public void Equals_Click(object sender, RoutedEventArgs e)
        {
            double ma = double.Parse(AlkoVolume.Text);
            double cpa = double.Parse(AlkoPercentAlready.Text);
            double cp = double.Parse(AlkoPercent.Text);

            double M = (cpa * ma) / cp - ma;


            WaterVolume.Text = M.ToString();
        }
        
    }
}

public class SimpleMath
{
    public static double Operation(double alkoPercentAlready, double alkoVolume, double alkoPercent)
    {
        return (alkoPercentAlready * alkoVolume) / (alkoPercent - alkoVolume);
    }
}