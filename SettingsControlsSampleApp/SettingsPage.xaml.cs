using CommunityToolkit.Labs.WinUI;
using Microsoft.UI.Xaml.Controls;
using System.Linq;

namespace SettingsControlsSampleApp;

public sealed partial class SettingsPage : Page
{
    public SettingsPage()
    {
        this.InitializeComponent();
    }

    private void SettingsCard_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
    }

    private void IsEnabledToggleSwitch_Toggled(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        if (sender is not ToggleSwitch toggleSwitch)
        {
            return;
        }

        foreach (SettingsCard item in this.MultipleItemsSettingsExpander.Items.OfType<SettingsCard>())
        {
            item.IsEnabled = toggleSwitch.IsOn;
        }
    }
}
