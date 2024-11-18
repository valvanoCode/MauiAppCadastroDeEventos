
using MauiAppCadastroDeEventos.Models;
using MauiAppCadastroDeEventos.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Media;

namespace MauiAppCadastroDeEventos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new Evento(); // Associa a model 'Evento' como o contexto de dados da página
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            // Obter o contexto de dados associado à página
            var evento = BindingContext as Evento;

            // Verificar se os dados foram preenchidos corretamente
            if (string.IsNullOrWhiteSpace(evento.Nome) ||
                evento.DataInicio == default ||
                evento.DataFim == default ||
                evento.NumeroParticipantes <= 0 ||
                evento.CustoPorParticipante <= 0)
            {
                await DisplayAlert("Erro", "Por favor, preencha todos os campos corretamente.", "OK");
                return;
            }

            // Verificar se a data de término é posterior à data de início
            if (evento.DataFim < evento.DataInicio)
            {
                await DisplayAlert("Erro", "A data de término deve ser posterior à data de início.", "OK");
                return;
            }

            // Navegar para a página de resumo e passar os dados do evento
            await Navigation.PushAsync(new ResumoPage(evento));
        }
    }
}



