using Avalonia.Controls;
using AvaloniaFirstLesson.ViewModels;

namespace AvaloniaFirstLesson.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}