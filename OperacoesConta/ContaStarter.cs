using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperacoesConta
{
    public class ContaStarter : Conta
    {   
        private double limite { get; }
        public ContaStarter()
        {
            Saldo = new Random().Next(00001, 99999);
            limite = new Random().Next(150, 5000);
        }

        public override bool Sacar(double valorSolicitado)
        {
            if(valorSolicitado > Saldo + limite)
                return false;
            
            return true;
        }

        public override void VisualizarSaldo(int idConta)
        {
            Console.Write($"{Environment.NewLine}Saldo + limite {Saldo + limite}{Environment.NewLine}Saldo = {Saldo}{Environment.NewLine}Limite = {limite}");

        }
    }
}