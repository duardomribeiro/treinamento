using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2.Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaRepository repository = new ContaRepository();

            #region Inserir Conta
            Conta conta = new Conta();
            conta.Limite = 100;
            conta.Saldo = 1000;
            conta.ContaCorrente = "654321";
            conta.Agencia = "7890";
            conta.Banco = "Santander";
            repository.Inserir(conta);
            #endregion

            #region Editar Conta
            Conta contaEditar = new Conta();
            conta.Id = 1;
            conta.Limite = 100;
            conta.Saldo = 1000;
            conta.ContaCorrente = "654321";
            conta.Agencia = "7890";
            conta.Banco = "Santander";
            #endregion

            #region Apagar Conta
            repository.Apagar(1);
            #endregion

            #region Obter uma conta
            Conta conta_1 = repository.Obter(1);
            #endregion
            
            #region Obter todas Contas
            IEnumerable<Conta> contas = repository.Obter();

            foreach (var item in contas)
            {
                Console.WriteLine(item.Banco);
            }
            #endregion


            #region Saque
            Conta contaSaque = repository.Obter(1);
            #endregion

            #region Deposito
            Conta contaDeposito = repository.Obter(1);
            #endregion

            #region Transferencia
            Conta contaTransferencia = repository.Obter(1);
            #endregion

            Console.ReadKey();
        }
    }
}
