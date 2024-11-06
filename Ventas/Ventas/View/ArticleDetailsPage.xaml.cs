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



namespace Ventas.View
{
    public partial class ArticleDetailsPage : Page
    {
        public ArticleDetailsPage(Articulo articulo)
        {
            InitializeComponent();
            DataContext = articulo;  // Establece el artículo como contexto de datos para la página
        }
    }
}
