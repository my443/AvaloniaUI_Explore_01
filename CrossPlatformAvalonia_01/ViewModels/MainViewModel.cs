using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using CrossPlatformAvalonia_01.Data;
using CrossPlatformAvalonia_01.Models;

namespace CrossPlatformAvalonia_01.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public ObservableCollection<Person> Items { get; } = new ObservableCollection<Person>(new AppDbContext().People);

    [ObservableProperty]
    private Person? selectedItem;

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
