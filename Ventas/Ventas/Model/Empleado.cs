using System.ComponentModel;

public class Empleado : INotifyPropertyChanged
{
    private string nss;
    private string nombre;
    private string apellidos;
    private int comision;


    public string Nss
    {
        get
        {
            return nss;
        }
        set
        {
            nss = value;
            OnPropertyChanged("Nss");
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

    public string Apellidos
    {
        get
        {
            return apellidos;
        }
        set
        {
            apellidos = value;
            OnPropertyChanged("Apellidos");
        }
    }

    public int Comision
    {
        get
        {
            return comision;
        }
        set
        {
            comision = value;
            OnPropertyChanged("Comision");
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