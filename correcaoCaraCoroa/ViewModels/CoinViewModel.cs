using CommunityToolkit.Mvvm.ComponentModel;
using correcaoCaraCoroa.Models;
using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correcaoCaraCoroa.ViewModels
{
    public partial class CoinViewModel : ObservableObject
    {
        //[ObservableProperty]
        public String LadoEscolhido;

        //[ObservableProperty]
        public String Imagem;

        //[ObservableProperty]
        public String Resultado;

        public ICommand FlipCommand { get; private set; }

        public CoinViewModel()
        {
            FlipCommand = new Command(Flip);
        }

        public void Flip()
        {
            Coin coin = new Coin();
            Resultado = coin.Jogar(LadoEscolhido);
            Imagem = $"{coin.Lado}.png";

        }
    }
}

