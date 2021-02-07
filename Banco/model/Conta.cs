using System;
using Banco.Resources;

namespace Banco.model
{
    public class Conta
    {
        private long id;
        private string nome;
        private double credito;
        private double saldo;
        private TipoConta tipoConta;

        public long Id
        {
            get => id;
            set => id = value;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public double Saldo
        {
            get => saldo;
            set => saldo = value;
        }

        public TipoConta TipoConta
        {
            get => tipoConta;
            set => tipoConta = value;
        }

        public Conta()
        {
        }

        public Conta(long id, string nome, double credito, double saldo, TipoConta tipoConta)
        {
            this.id = id;
            this.nome = nome;
            this.credito = credito;
            this.saldo = saldo;
            this.tipoConta = tipoConta;
        }

        public bool Sacar(double valor)
        {
            if (saldo - valor < (credito *-1))
            {
                throw new Exception("Saldo insuficiente!");
            }
            saldo -= valor;
            Console.WriteLine(Traducoes.__0___SEU_NOVO_SALDO_DA_SUA_CONTA_É____1__, Nome, saldo);
            return true;
        }
        
        public void Depositar(double valor)
        {
            this.saldo += valor;
            Console.WriteLine(Traducoes.__0___SEU_NOVO_SALDO_DA_SUA_CONTA_É____1__, Nome, saldo);
        }
        
        public void Transferir(double valor, Conta contaDestino)
        {
            if (Sacar(valor))
            {
                contaDestino.Depositar(valor);
                Console.WriteLine(Traducoes.TRANSFERENCIA_CONCLUIDA_COM_SUCESSO_PARA___0____O_NOVO_SALDO_É_DE____1__, contaDestino.nome, contaDestino.saldo);
            }
        }
        
    }
}