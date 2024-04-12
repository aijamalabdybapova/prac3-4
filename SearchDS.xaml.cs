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
using System.Windows.Shapes;
using PRACTICA.PRACTICADataSetTableAdapters;


namespace PRACTICA
{
    /// <summary>
    /// Логика взаимодействия для SearchDS.xaml
    /// </summary>
    public partial class SearchDS : Window
    {
        MoviesTableAdapter movies = new MoviesTableAdapter();
        GenresTableAdapter genres = new GenresTableAdapter();

        public SearchDS()
        {
            InitializeComponent();
            MoviesDSs.ItemsSource = movies.GetData();
            GenreCbx.ItemsSource = genres.GetData();
            GenreCbx.DisplayMemberPath = "GenreName";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MoviesDSs.ItemsSource = movies.SearchByName(SearchTxt.Text);
        }

        private void GenreCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GenreCbx.SelectedItem != null)
            {
                var ID_Genre = (int)(GenreCbx.SelectedItem as DataRowView).Row[0];
                MoviesDSs.ItemsSource=movies.FilterByGenre(ID_Genre);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MoviesDSs.ItemsSource=movies.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var Window1 = new Window1();
            Window1.Show();
            this.Close();
        }
    }
}
