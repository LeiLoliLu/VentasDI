using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Ventas.View
{
    /// <summary>
    /// Lógica de interacción para ArticlesPage.xaml
    /// </summary>
    public partial class ArticlesPage : Page
    {
        private ObservableCollection<Articulo> articles;
        private ICollectionView collectionView;
        public ArticlesPage()
        {
            InitializeComponent();

            articles = new ObservableCollection<Articulo>()
            {
                new Articulo { Codigo = 1, Nombre = "iPear 12", Descripcion = "The phone with a Pear shape, and a Personal Assistant. Model 12.", Precio = 165.28, Iva = 21, Imagen="C:\\Users\\DAM2XX\\Desktop\\DI\\Ventas\\Ventas\\Images\\image.png" },
                new Articulo { Codigo = 2, Nombre = "iPear 12 Pro", Descripcion = "The phone with a Pear shape, and a Personal Assistant. Model 12 PRO.", Precio = 227.27, Iva = 21, Imagen="C:\\Users\\DAM2XX\\Desktop\\DI\\Ventas\\Ventas\\Images\\image-1.png" },
                new Articulo { Codigo = 3, Nombre = "iPear 13", Descripcion = "The phone with a Pear shape, and a Personal Assistant. Model 13.", Precio = 288.46, Iva = 10, Imagen = "C:\\Users\\DAM2XX\\Desktop\\DI\\Ventas\\Ventas\\Images\\image-2.png"},
                new Articulo { Codigo = 4, Nombre = "iPear 13 Pro", Descripcion = "The phone with a Pear shape, and a Personal Assistant. Model 13 PRO.", Precio = 336.53, Iva = 10, Imagen = "C:\\Users\\DAM2XX\\Desktop\\DI\\Ventas\\Ventas\\Images\\image-3.png"},
                new Articulo { Codigo = 5, Nombre = "PearBook", Descripcion = "The new pear laptop with a colored back.", Precio = 480.76, Iva = 21, Imagen = "C:\\Users\\DAM2XX\\Desktop\\DI\\Ventas\\Ventas\\Images\\image-4.png"},
                new Articulo { Codigo = 6, Nombre = "PearPad", Descripcion = "The Pear tablet with PearOS, and PearChat.", Precio = 288.46, Iva = 10, Imagen="C:\\Users\\DAM2XX\\Desktop\\DI\\Ventas\\Ventas\\Images\\image-5.png" },
                new Articulo { Codigo = 7, Nombre = "PearTV", Descripcion = "The internet delivering device for your widescreen TV.", Precio = 192.30, Iva = 4, Imagen="C:\\Users\\DAM2XX\\Desktop\\DI\\Ventas\\Ventas\\Images\\image-6.png" }
            };

            // Configuración de la vista de colección con filtro
            collectionView = CollectionViewSource.GetDefaultView(articles);
            collectionView.Filter = FilterArticles;

            // Asignación de la colección filtrada al ItemsControl
            ArticlesGrid.ItemsSource = collectionView;
        }
        private void OnItemClicked(object sender, MouseButtonEventArgs e)
        {
            // Obtener el artículo asociado al clic.
            var clickedItem = (sender as FrameworkElement)?.DataContext as Articulo;

            if (clickedItem != null)
            {
                // Crear la nueva página pasando el artículo seleccionado
                var detailsPage = new ArticleDetailsPage(clickedItem);

                // Navegar a la nueva página
                NavigationService?.Navigate(detailsPage);
            }
        }
        // Método de filtro de artículos según el texto en el cuadro de búsqueda
        private bool FilterArticles(object item)
        {
            if (string.IsNullOrEmpty(SearchBox.Text))
                return true;

            var articulo = item as Articulo;
            return articulo.Nombre.IndexOf(SearchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        // Evento para actualizar el filtro al cambiar el texto de búsqueda
        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            collectionView.Refresh();
        }


    }
}
