
using System.Windows.Input;
using MauiAppCadastroDeEventos.Models;
using MauiAppCadastroDeEventos.Views;
using Microsoft.Maui.Controls;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiAppCadastroDeEventos.ViewModels;

public class MainPageViewModel : BaseViewModel
{
    public Evento Evento { get; set; } = new Evento
    {
        DataInicio = DateTime.Now,
        DataFim = DateTime.Now
    };

    public ICommand CadastrarCommand { get; }

    public MainPageViewModel()
    {
        CadastrarCommand = new Command(CadastrarEvento);
    }

    private async void CadastrarEvento()
    {
        // Validação básica
        if (string.IsNullOrWhiteSpace(Evento.Nome) || Evento.NumeroParticipantes <= 0 || Evento.CustoPorParticipante <= 0)
        {
            await Application.Current.MainPage.DisplayAlert("Erro", "Preencha todos os campos corretamente!", "OK");
            return;
        }

        // Navega para a página de resumo com os dados do evento
        var resumoPage = new ResumoPage();
        resumoPage.BindingContext = Evento;

        await Application.Current.MainPage.Navigation.PushAsync(resumoPage);
    }
}