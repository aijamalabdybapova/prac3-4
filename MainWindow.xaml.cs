using System;
using System.Collections.Generic;
using System.Data;
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
using PRACTICA.PRACTICADataSetTableAdapters;

    
namespace PRACTICA
{
    public partial class MainWindow : Window
    {

        private void DS_Click(object sender, RoutedEventArgs e)
        {
            var Window1 = new Window1();
            Window1.Show();
            this.Close();   

        }

        private void EF_Click(object sender, RoutedEventArgs e)
        {
            var Window2 = new Window2();
            Window2.Show();
            this.Close();
        }
    }
}
