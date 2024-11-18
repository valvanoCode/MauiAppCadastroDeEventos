
using Microsoft.Maui.Controls;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiAppCadastroDeEventos;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Define a página inicial do aplicativo como uma NavigationPage
        MainPage = new NavigationPage(new MainPage());
    }
}