using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls; // ✅ RIGHT namespace for MAUI

namespace OrthoGlitch;

public partial class SplashPage : ContentPage
{
    public SplashPage()
    {
        InitializeComponent();
        Start();
    }

    private async void Start()
    {
        await Task.Delay(2000);

        // Use Application.Current.MainPage instead of Navigation
        Application.Current.MainPage = new NavigationPage(new MainPage());
    }
}
