using MauiAppCadastroDeEventos.Models;
using Microsoft.Maui.Controls;

namespace MauiAppCadastroDeEventos.Views;

public partial class ResumoPage : ContentPage
{
    public ResumoPage()
    {
    }

    public ResumoPage(Evento evento)
    {
        InitializeComponent();
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}