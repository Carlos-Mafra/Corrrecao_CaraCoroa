using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correcaoCaraCoroa.Models
{
    public class Coin
    {
        public string Lado {  get; set; }
        public string Jogar()
        {
            int ladoSorteado = new Random().Next(2);
            Lado = ladoSorteado == 0 ? "cara" : "coroa";
            return (Lado);
        }

        public string Jogar(string ladoEscolhido)
        {

            int ladoSorteado = new Random().Next(2);
            Lado = ladoSorteado == 0 ? "cara" : "coroa";
            string resultado = Lado == ladoEscolhido ?
            $"Que pena, você pediu {ladoEscolhido} e deu {Lado}": 
            $"Que pena, você pediu {ladoEscolhido} e deu {Lado}";
            return (resultado);

        }

    }

}