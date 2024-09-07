using System.Collections.ObjectModel;
using System.Windows.Input;

public class MediaViewModel
{
    public ObservableCollection<MediaItem> MediaItems { get; set; } = new ObservableCollection<MediaItem>();

    public ICommand AddCommand { get; }
    public ICommand EditCommand { get; }
    public ICommand DeleteCommand { get; }
    public ICommand ImportCommand { get; }
    public ICommand ExportCommand { get; }

    public MediaViewModel()
    {
        AddCommand = new RelayCommand(AddMediaItem);
        EditCommand = new RelayCommand(EditMediaItem, CanExecuteEditOrDelete);
        DeleteCommand = new RelayCommand(DeleteMediaItem, CanExecuteEditOrDelete);
        ImportCommand = new RelayCommand(ImportMediaItems);
        ExportCommand = new RelayCommand(ExportMediaItems);
    }

    private void AddMediaItem(object parameter)
    {
        // Logika dodawania nowego elementu
    }

    private void EditMediaItem(object parameter)
    {
        // Logika edycji wybranego elementu
    }

    private void DeleteMediaItem(object parameter)
    {
        // Logika usuwania wybranego elementu
    }

    private void ImportMediaItems(object parameter)
    {
        // Logika importu elementów z pliku
    }

    private void ExportMediaItems(object parameter)
    {
        // Logika eksportu elementów do pliku
    }

    private bool CanExecuteEditOrDelete(object parameter)
    {
        return parameter != null && parameter is MediaItem;
    }
}
