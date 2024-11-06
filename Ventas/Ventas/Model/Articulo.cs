using System.ComponentModel;
using System.Windows.Controls;

public class Articulo : INotifyPropertyChanged
{
    private int codigo;
    private string nombre;
    private string descripcion;
    private double precio;
    private int iva;
    private string imagen;


    public int Codigo
    {
        get
        {
            return codigo;
        }
        set
        {
            codigo = value;
            OnPropertyChanged("Codigo");
        }
    }

    public string Nombre
    {
        get
        {
            return nombre;
        }
        set
        {
            nombre = value;
            OnPropertyChanged("Nombre");
        }
    }

    public string Descripcion
    {
        get
        {
            return descripcion;
        }
        set
        {
            descripcion = value;
            OnPropertyChanged("Descripcion");
        }
    }

    public double Precio
    {
        get
        {
            return precio;
        }
        set
        {
            precio = value;
            OnPropertyChanged("Precio");
        }
    }
    public int Iva
    {
        get
        {
            return iva;
        }
        set
        {
            iva = value;
            OnPropertyChanged("Iva");
        }
    }
    public string Imagen
    {
        get
        {
            return imagen;
        }
        set
        {
            imagen = value;
            OnPropertyChanged("Imagen");
        }
    }

    #region INotifyPropertyChanged Members

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion
}