using PRACTICA.PRACTICADataSetTableAdapters;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MoviesTableAdapter movies = new MoviesTableAdapter();
        public Window1()
        {
            InitializeComponent();
            MoviesDS.ItemsSource = movies.GetFullMovies();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MoviesDS.Columns[0].Visibility = Visibility.Collapsed;
            MoviesDS.Columns[1].Header="Название фильма";
            MoviesDS.Columns[2].Visibility = Visibility.Collapsed;
            MoviesDS.Columns[3].Visibility = Visibility.Collapsed;
            MoviesDS.Columns[4].Header = "Фамилия режиссера";
            MoviesDS.Columns[5].Header = "Имя режиссера";
            MoviesDS.Columns[6].Header = "Отчество режиссера";
            MoviesDS.Columns[7].Header = "Жанр";

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var SearchDS = new SearchDS();
            SearchDS.Show();
            this.Close();
        }
    }
}
