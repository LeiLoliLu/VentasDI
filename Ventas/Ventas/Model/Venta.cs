using System;
using System.ComponentModel;

public class Venta : INotifyPropertyChanged
{
   
    private int codigo;
    private DateTime fecha;
    private Empleado vendedor;
    private Articulo item;
    private int cantidad;
    private double importe;
    private string numtarjeta;


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

    public DateTime Fecha
    {
        get
        {
            return fecha;
        }
        set
        {
            fecha = value;
            OnPropertyChanged("Fecha");
        }
    }

    public Empleado Vendedor
    {
        get
        {
            return vendedor;
        }
        set
        {
            vendedor = value;
            OnPropertyChanged("Vendedor");
        }
    }

    public Articulo Item
    {
        get
        {
            return item;
        }
        set
        {
            item = value;
            OnPropertyChanged("Item");
        }
    }
    public int Cantidad
    {
        get
        {
            return cantidad;
        }
        set
        {
            cantidad = value;
            OnPropertyChanged("Cantidad");
        }
    }
    public double Importe
    {
        get
        {
            return importe;
        }
        set
        {
            importe = value;
            OnPropertyChanged("Importe");
        }
    }
    public string Numtarjeta
    {
        get
        {
            return numtarjeta;
        }
        set
        {
            numtarjeta = value;
            OnPropertyChanged("Numtarjeta");
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