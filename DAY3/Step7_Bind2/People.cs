// People.cs 
using System;
using System.ComponentModel;

class People : INotifyPropertyChanged
{
    private string name;
    private string address;

    public event PropertyChangedEventHandler? PropertyChanged;

    public string Name
    {
        get { return name; }
        set
        {
            name = value;

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }
    }

    public string Address
    {
        get { return address; }
        set
        {
            address = value;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("Address"));
            }
        }
    }
}