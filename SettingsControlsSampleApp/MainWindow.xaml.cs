using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Linq;

namespace SettingsControlsSampleApp;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
    }

    private void NavigationView_Loaded(object sender, RoutedEventArgs e)
    {
        this.NavigationView.SelectionChanged += this.NavigationView_SelectionChanged;
        this.NavigationView.SelectedItem = this.NavigationView.MenuItems.FirstOrDefault();
    }

    private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        if (args.IsSettingsSelected is true)
        {
            this.NavigationView.Header = "Settings";
            this.ContentFrame.Navigate(typeof(SettingsPage));
            return;
        }

        this.NavigationView.Header = "Start Page";
        this.ContentFrame.Navigate(typeof(StartPage));
    }
}