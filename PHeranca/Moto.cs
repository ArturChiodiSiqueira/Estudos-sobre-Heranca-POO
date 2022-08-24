using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHeranca
{
    internal class Moto : Veiculo
    {
        int Cilindrada;
        bool PartidaEletrica;

        public Moto(string marca, string modelo, int rodas, int capacidade, float preco, string cor, int cilindrada, bool partidaEletrica) : base(marca, modelo, rodas, capacidade, preco, cor)
        {
            Cilindrada = cilindrada;
            PartidaEletrica = partidaEletrica;
        }

        public override string ToString()
        {
            string mensagem;

            if (PartidaEletrica)
                mensagem = "Sim";
            else 
                mensagem = "Não";

            return base.ToString() + "\nCilindradas: " + Cilindrada + "\nPartida Elétrica: " + mensagem;
        }
    }
}
