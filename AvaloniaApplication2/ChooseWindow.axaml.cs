using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaApplication2;

public partial class ChooseWindow : Window
{
    public ChooseWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Button_Click_Single(object? sender, RoutedEventArgs e)
    {
        var openFormWindowSingle = new FormWindowSingle();
        openFormWindowSingle.Show();
        Close();
    }

    private void Button_Click_Group(object? sender, RoutedEventArgs e)
    {
        var openFormWindowGroup = new FormWindowGroup();
        openFormWindowGroup.Show();
        Close();
    }

   
}