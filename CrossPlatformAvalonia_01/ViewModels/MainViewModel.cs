using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using CrossPlatformAvalonia_01.Data;

namespace CrossPlatformAvalonia_01.ViewModels;

public partial class MainViewModel : ViewModelBase, INotifyPropertyChanged
{
    public ObservableCollection<Person> Items { get; } = new ObservableCollection<Person>(new AppDbContext().People);

    Person? _selectedItem;

    public Person? SelectedItem
    {
        get => _selectedItem;
        set
        {
            if (_selectedItem != value)
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }
    }

    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";

    [ObservableProperty]
    private int counter;

    [RelayCommand]
    private void IncrementCounter()
    {
        Counter++;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
