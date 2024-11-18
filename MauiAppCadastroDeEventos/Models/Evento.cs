using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCadastroDeEventos.Models;

public class Evento
{
    public string Nome { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public int NumeroParticipantes { get; set; }
    public string Local { get; set; }
    public decimal CustoPorParticipante { get; set; }

    public TimeSpan Duracao => DataFim - DataInicio;
    public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
}