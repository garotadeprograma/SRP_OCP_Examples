using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperacoesConta
{
    public abstract class Conta
    {
        protected double Saldo { get; set; }

        public abstract void VisualizarSaldo (int idConta);

        public abstract bool Sacar(double valorSolicitado);

        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }
 
    }
}