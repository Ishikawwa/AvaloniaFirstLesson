using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Diagnostics;

namespace AvaloniaFirstLesson.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private string _firstName;
        private string _email = "";
        private string _password = "";
        [ObservableProperty] private string _successMessage = "";
        [ObservableProperty] private string _errorMessage = "";

        public bool _isErrorVisible => _errorMessage != "";
        public bool _isSuccessVisible => _errorMessage != "";

        public string FirstName
        {
            get => _firstName;
            set
            {
                SetProperty(ref _firstName, value);
                SuccessMessage = "";
            }
        }
        public string Email
        {
            get => _email;
            set
            {  
                SetProperty(ref _email, value);
                SuccessMessage = "";
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                SetProperty(ref _password, value);
                SuccessMessage = "";
            }
        }

        [RelayCommand]
        private void SignUp()
        {

            if (string.IsNullOrWhiteSpace(_firstName))
            {
                ErrorMessage = "Please enter your first name!";
            }
            else if (string.IsNullOrWhiteSpace(_email))
            {
                ErrorMessage = "Please enter your email!";
            }
            else if (string.IsNullOrWhiteSpace(_password))
            {
                ErrorMessage = "Please enter your password!";
            }

            Debug.WriteLine($"{_firstName}, {_email}, {_password}");

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
