using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OperacoesConta;
using Xunit;

namespace OperacoesContaTest
{
    public class ContasTest
    {
        [Theory]
        [InlineData(20322)]
        [InlineData(25632)]
        public void ContaStarter_VisualizarSaldo_Sucesso(int id)
        {
            var conta = new ContaStarter();

            conta.VisualizarSaldo(id);

            Assert.True(true);
        }

        [Theory]
        [InlineData(100000)]
        public void ContaStarter_Sacar_Falha_ValorSolicitadoMaiorQueSaldo(double valor)
        {   
            var conta = new ContaStarter();
            var result = conta.Sacar(valor);

            Assert.False(result, "Não foi possível sacar");
        }

        [Theory]
        [InlineData(10000)]
        public void ContaStarter_Sacar_Sucesso_ValorSolicitadoMaiorQueSaldo(double valor)
        {   
            var conta = new ContaStarter();
            var result = conta.Sacar(valor);

            Assert.True(result, "Saque Autorizado");
        }
    }
}