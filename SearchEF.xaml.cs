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
    /// Логика взаимодействия для SearchEF.xaml
    /// </summary>
    public partial class SearchEF : Window
    {
        private PRACTICAEntities contextM = new PRACTICAEntities();
        public SearchEF()
        {
            InitializeComponent();
            MoviesEFs.ItemsSource = contextM.Movies.ToList();
            DirectorsCbx.ItemsSource = contextM.Directors.ToList();
            DirectorsCbx.DisplayMemberPath = "Surname";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MoviesEFs.ItemsSource = contextM.Movies.ToList().Where(item => item.MovieName.Contains(SearchTxt.Text)).ToList();
        }

        private void DirectorsCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DirectorsCbx.SelectedItem != null)
            {
                var selected = DirectorsCbx.SelectedItem as Directors;
                MoviesEFs.ItemsSource = contextM.Movies.ToList().Where(item => item.Directors == selected).ToList();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MoviesEFs.ItemsSource = contextM.Movies.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var Window2 = new Window2();
            Window2.Show();
            this.Close();
        }
    }
}
