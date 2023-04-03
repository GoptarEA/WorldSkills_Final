using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        
        var chooseWin = new ChooseWindow();
        chooseWin.Show();
        Close();
    }
}