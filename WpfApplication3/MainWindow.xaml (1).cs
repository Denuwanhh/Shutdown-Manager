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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WpfApplication3
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
    
       public static String mtime = DateTime.Now.ToString("mm ");
       public static String htime = DateTime.Now.ToString("h ");
       public static String ttime = DateTime.Now.ToString("tt");
      

       public static int a = 1;
        
       private void Move(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void HHDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {           
            HHDisplay.Text = htime;         
        }

        private void MMDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {            
            MMDisplay.Text = mtime;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int hIncrese = int.Parse(htime);

            if (hIncrese == 11)
            {
                Button_Click_8(sender, e);
                
            }
            
            
            if (hIncrese == 12)
            {
                
                hIncrese = 01;
            }
            else
            {
                hIncrese = hIncrese + 1;
            }

            htime = hIncrese.ToString();
            HHDisplay.Text = htime;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int mIncrese = int.Parse(mtime);
             

            if (mIncrese == 59)
            {
                mIncrese = 00;
                Button_Click_3(sender, e);

            }
            else
            {
                mIncrese = mIncrese + 1;
            }

            mtime = mIncrese.ToString();

            if (mtime == "0")
            {
                mtime = "00";
            }
            if (mtime == "1")
            {
                mtime = "01";
            }
            if (mtime == "2")
            {
                mtime = "02";
            }
            if (mtime == "3")
            {
                mtime = "03";
            }
            if (mtime == "4")
            {
                mtime = "04";
            }
            if (mtime == "5")
            {
                mtime = "05";
            }
            if (mtime == "6")
            {
                mtime = "06";
            }
            if (mtime == "7")
            {
                mtime = "07";
            }
            if (mtime == "8")
            {
                mtime = "08";
            }
            if (mtime == "9")
            {
                mtime = "09";
            }


           
            MMDisplay.Text = mtime;

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int hIncrese = int.Parse(htime);
            


            if (hIncrese == 01)
            {
                Button_Click_9(sender, e);
                hIncrese = 12;
            }
            else
            {
                hIncrese = hIncrese - 1;
            }

            htime = hIncrese.ToString();
            HHDisplay.Text = htime;

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            int mIncrese = int.Parse(mtime);

            if (mIncrese == 00)
            {
                Button_Click_5(sender, e);
                mIncrese = 59;
            }
            else
            {
                mIncrese = mIncrese - 1;
            }

            mtime = mIncrese.ToString();

            if (mtime == "0")
            {
                mtime = "00";
            }
            if (mtime == "1")
            {
                mtime = "01";
            }
            if (mtime == "2")
            {
                mtime = "02";
            }
            if (mtime == "3")
            {
                mtime = "03";
            }
            if (mtime == "4")
            {
                mtime = "04";
            }
            if (mtime == "5")
            {
                mtime = "05";
            }
            if (mtime == "6")
            {
                mtime = "06";
            }
            if (mtime == "7")
            {
                mtime = "07";
            }
            if (mtime == "8")
            {
                mtime = "08";
            }
            if (mtime == "9")
            {
                mtime = "09";
            }

            MMDisplay.Text = mtime;

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            int M = int.Parse(mtime);
            int H = int.Parse(htime);

            String rm = DateTime.Now.ToString("mm ");
            String rh = DateTime.Now.ToString("h ");
            String rttime = DateTime.Now.ToString("tt");

            int RM = int.Parse(rm);
            int RH = int.Parse(rh);
           
            DateTime a = new DateTime(2010, 05, 12, RH, RM, 00);
            DateTime b = new DateTime(2010, 05, 12, H, M, 00);
            double time = (b.Subtract(a).TotalSeconds);

            
            
            if(time<0)
            {
                time = time * -1;
            }

            if (RM > M && H == RH )
            {
                time = 86400 - time;
            }

            if (RH > H)
            {
                time = 86400 - time;
            }


           
                          
             Window1 Alert1 = new Window1();
             Alert1.Show();

             this.WindowState = WindowState.Minimized;

             Process.Start("shutdown", "/s /t " + time);
                 
             this.Close();         

        }

        private void TTDisply_TextChanged(object sender, TextChangedEventArgs e)
        {
            TTDisplay.Text = ttime;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

            if (ttime.Equals("PM"))
            {
                ttime = "AM";
                TTDisplay.Text = ttime;
            }
            else
            {
                if (ttime.Equals("AM"))
                {
                    ttime = "PM";
                    TTDisplay.Text = ttime;
                }
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (ttime.Equals("PM"))
            {
                ttime = "AM";
                TTDisplay.Text = ttime;
            }
            else
            {

                if (ttime.Equals("AM"))
                {
                    ttime = "PM";
                    TTDisplay.Text = ttime;
                }
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {



        } 

     
                
    }

    
}
