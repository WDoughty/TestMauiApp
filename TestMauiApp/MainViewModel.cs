using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace TestMauiApp
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        private string firstName;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        private string lastName;


        public string FullName => $"{FirstName} {LastName}";

        [ObservableProperty]
        private bool isEnabled = true;

        [RelayCommand]
        public void Submit()
        {
            Debug.WriteLine("Here");
        }
    }
}
