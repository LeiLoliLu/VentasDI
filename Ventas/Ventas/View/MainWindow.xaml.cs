using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Ventas
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        // Método para navegar a la página de artículos
        private void GoToArticlesPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("View/ArticlesPage.xaml", UriKind.Relative));
            MainFrame.Visibility = Visibility.Visible;
            MenuPanel.Visibility = Visibility.Collapsed; // Oculta el menú
            PearLogo.Visibility = Visibility.Collapsed; // Oculta el logo
            BackButton.Visibility = Visibility.Visible; // Muestra el botón de regreso
        }


        // Método para regresar al salvapantallas
        private void GoToSplashScreen(object sender, RoutedEventArgs e)
        {
            MainFrame.Visibility = Visibility.Collapsed; // Oculta el Frame
            MenuPanel.Visibility = Visibility.Collapsed; // Oculta el menú
            SplashImage.Visibility = Visibility.Visible; // Muestra el salvapantallas
            PearLogo.Visibility = Visibility.Collapsed; // Oculta el logo
            BackButton.Visibility = Visibility.Collapsed; // Oculta el botón de regreso
        }

        // Método para mostrar el menú cuando se hace clic en la imagen del salvapantallas
        private void SplashImage_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            SplashImage.Visibility = Visibility.Collapsed; // Oculta el salvapantallas
            MenuPanel.Visibility = Visibility.Visible; // Muestra el menú
            PearLogo.Visibility = Visibility.Visible; // Muestra el logo
            MainFrame.Visibility = Visibility.Visible; // Muestra el Frame
        }

        // Método para el botón "Back"
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Visibility = Visibility.Collapsed; // Oculta el Frame
            MainFrame.Content = null; // Limpia el contenido del Frame
            MenuPanel.Visibility = Visibility.Visible; // Muestra el menú
            PearLogo.Visibility = Visibility.Visible; // Muestra el logo
            BackButton.Visibility = Visibility.Collapsed; // Oculta el botón de regreso
        }
    }
}
