using System;
using System.ComponentModel;

public class MediaItem : INotifyPropertyChanged
{
    private string _tytul;
    private string _rezyserAutor;
    private string _wydawcaStudio;
    private string _nosnik;
    private TimeSpan _dlugosc;
    private DateTime _dataWydania;

    public string Tytul
    {
        get => _tytul;
        set
        {
            _tytul = value;
            OnPropertyChanged(nameof(Tytul));
        }
    }

    public string RezyserAutor
    {
        get => _rezyserAutor;
        set
        {
            _rezyserAutor = value;
            OnPropertyChanged(nameof(RezyserAutor));
        }
    }

    public string WydawcaStudio
    {
        get => _wydawcaStudio;
        set
        {
            _wydawcaStudio = value;
            OnPropertyChanged(nameof(WydawcaStudio));
        }
    }

    public string Nosnik
    {
        get => _nosnik;
        set
        {
            _nosnik = value;
            OnPropertyChanged(nameof(Nosnik));
        }
    }

    public TimeSpan Dlugosc
    {
        get => _dlugosc;
        set
        {
            _dlugosc = value;
            OnPropertyChanged(nameof(Dlugosc));
        }
    }

    public DateTime DataWydania
    {
        get => _dataWydania;
        set
        {
            _dataWydania = value;
            OnPropertyChanged(nameof(DataWydania));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
