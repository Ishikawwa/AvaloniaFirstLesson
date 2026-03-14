using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Diagnostics;

namespace AvaloniaFirstLesson.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty] private string _firstName = "";
        [ObservableProperty] private string _email = "";
        [ObservableProperty] private string _password = "";
        [ObservableProperty] private string _successMessage = "";

        [RelayCommand]
        private void SignUp()
        {
            if (string.IsNullOrWhiteSpace(FirstName) ||
                string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(Password))
                return;

            Debug.WriteLine($"{FirstName}, {Email}, {Password}");

            FirstName = "";
            Email = "";
            Password = "";
            SuccessMessage = "Вы успешно авторизовались";
        }
    }
}




// Practise -->

//public string FirstName
//{
//    get { return _firstName; } //or get => _age;
//    set
//    {
//        SetProperty(ref _firstName, value);
//        VisibleAge = "";
//    }
//}

//public string VisibleAge
//{
//    get => _visibleAge;
//    set => SetProperty(ref _visibleAge, value);
//}

//[RelayCommand]
//public void ButtonClickCommand(string ageValue)
//{
//    VisibleAge = ageValue;
//    Debug.Write(ageValue);
//    string successMessage = "Success";
//}
