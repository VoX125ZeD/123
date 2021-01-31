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
using System.Drawing;
using System.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Bitmap image1;
              string str = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(str);
            image1 = new Bitmap(System.IO.Directory.GetCurrentDirectory()+@"\DS2017_TP09_color@4x.bmp");
            Console.WriteLine(image1.GetPixel(0, 0));
            image1.SetPixel(0, 0, System.Drawing.Color.Black);
            image1.Save(System.IO.Directory.GetCurrentDirectory() + @"\DS2017_TP09_color@4x.bmp");
         //  Console.WriteLine(str);
            
        }
    }
}
