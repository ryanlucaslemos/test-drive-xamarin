using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TesteDrive.Views
{
    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string PrecoFormatado { get => $"R${Preco}"; }
    }

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }
        public ListagemView()
        {
            InitializeComponent();
            Veiculos = new List<Veiculo>()
            {
                new Veiculo() {Nome = "Fiesta", Preco = 40000  },
                new Veiculo() {Nome =  "HB20", Preco = 50000  },
                new Veiculo() {Nome = "Civic", Preco = 60000  },
            };

            BindingContext = this;
        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            //DisplayAlert("Test Drive", $"Você tocou no modelo {veiculo.Nome}, que custa {veiculo.PrecoFormatado}", "Ok");

            Navigation.PushAsync(new DetalheView());
        }
    }
}
