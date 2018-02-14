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
using System.Windows.Shapes;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        String stime = DateTime.Now.ToString("ss");
        
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();                    
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            string m = MainWindow.mtime;
            string h = MainWindow.htime;
            string t = MainWindow.ttime;
            string s = stime;

            ADis.Text = "Successfully set shutdown timer.\nPlease make sure yours unsaved works save before \n"+h+" : "+m+" : "+s+" "+t;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("shutdown", "/a");

            WpfApplication3.MainWindow NW = new WpfApplication3.MainWindow();
            
            NW.Show();
            this.Close();
           
        }
     
    }
}
