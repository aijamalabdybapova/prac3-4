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

namespace PRACTICA
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private PRACTICAEntities contextM = new PRACTICAEntities();
        public Window2()
        {
            InitializeComponent();
            Moviesef.ItemsSource = contextM.Movies.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var SearchEF = new SearchEF();
            SearchEF.Show();
            this.Close();
        }
    }
}
