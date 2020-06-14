using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TesteDrive
{
    public class Veiculo
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }
        public MainPage()
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
    }
}
