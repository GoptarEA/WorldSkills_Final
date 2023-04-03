using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication2;

public partial class FormWindowGroup : Window
{
    public FormWindowGroup()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }
    private void BackToMenu(object? sender, RoutedEventArgs e)
    {
        var openChooseWindow = new ChooseWindow();
        openChooseWindow.Show();
        Close();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}