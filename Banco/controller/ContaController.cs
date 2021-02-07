using System;
using System.Collections.Generic;
using Banco.model;
using Banco.Resources;

namespace Banco.controller
{
    public class ContaController
    {
        private static List<Conta> contasList = new List<Conta>();

        public void ListarContas()
        {
            Console.WriteLine("==============================");
            if (contasList.Count == 0)
            {
                Console.WriteLine(Traducoes.NENHUM_USUARIO_CADASTRADO);
            }
            else
            {
                Console.WriteLine(Traducoes.CONTAS_CADASTRADAS);
                Console.WriteLine("==============================\n");
                foreach (var conta in contasList)
                {
                    Console.WriteLine("++++++++++++++++++++++++++++++");
                    Console.WriteLine("ID: " + conta.Id);
                    Console.WriteLine(Traducoes.NOME__ + conta.Nome);
                    Console.WriteLine(Traducoes.SALDO__ + conta.Saldo);
                    Console.WriteLine(Traducoes.TIPO_DE_CONTA__ + conta.TipoConta);
                    Console.WriteLine("++++++++++++++++++++++++++++++\n");
                }
                
            }
            Console.WriteLine("==============================\n");
            Console.WriteLine(Traducoes.ESC_PARA_VOLTAR__);
            Console.ReadKey();
        }
        public void InserirConta()
        {
            Console.WriteLine("==============================");
            Console.WriteLine(Traducoes.CRIAR_NOVA_CONTA);
            Console.WriteLine("==============================");
            Console.WriteLine(Traducoes.DIGITE_1_PARA_PESSOA_FISICA_OU_2_PARA_PESSOA_JURIDICA);
            int tipoDeConta = int.Parse(Console.ReadLine());
            Console.WriteLine(Traducoes.DIGITE_SEU_NOME);
            string nome = Console.ReadLine();
            Console.WriteLine(Traducoes.DIGITE_O_SALDO_INICIAL);
            double saldo = Double.Parse(Console.ReadLine());
            Console.WriteLine(Traducoes.ENTRE_COM_SEU_CREDITO_DISPONIVEL);
            double credito = Double.Parse(Console.ReadLine());

            int id = new Random().Next(99);
            
            contasList.Add(new Conta(id,nome,credito,saldo,(TipoConta) tipoDeConta));
        }
        public void Transferir()
        {
            Console.WriteLine("==============================");
            Console.WriteLine(Traducoes.TRANSFERIR_VALOR);
            Console.WriteLine("==============================");
            Console.WriteLine(Traducoes.DIGITE_O_ID_DA_CONTA_DE_ORIGEM);
            int idOrigem = int.Parse(Console.ReadLine());
            Console.WriteLine(Traducoes.DIGITE_O_ID_DA_CONTA_DESTINO);
            int idDestino = int.Parse(Console.ReadLine());
            Console.WriteLine(Traducoes.DIGITE_O_VALOR_A_SER_TRANSFERIDO);
            double valor = double.Parse(Console.ReadLine());
            Conta contaOrigem = new Conta();
            Conta contaDestino = new Conta();
            foreach (var conta in contasList)
            {
                if (conta.Id == idOrigem)
                {
                    contaOrigem = conta;
                }
                else if (conta.Id == idDestino)
                {
                    contaDestino = conta;
                }
            }
            contaOrigem.Transferir(valor,contaDestino);
            Console.WriteLine("==============================\n");
            Console.WriteLine(Traducoes.ESC_PARA_VOLTAR__);
            Console.ReadKey();
        }
        public void Sacar()
        {
            Console.WriteLine("==============================");
            Console.WriteLine(Traducoes.SACAR_VALOR);
            Console.WriteLine("==============================");
            Console.WriteLine(Traducoes.DIGITE_O_ID_DA_CONTA);
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(Traducoes.DIGITE_O_VALOR_A_SER_SACADO_DA_CONTA);
            double valor = double.Parse(Console.ReadLine());
            foreach (var conta in contasList)
            {
                if (conta.Id == id)
                {
                    conta.Sacar(valor);
                }
            }
            Console.WriteLine("==============================\n");
            Console.WriteLine(Traducoes.ESC_PARA_VOLTAR__);
            Console.ReadKey();
        }
        public void Depositar()
        {
            Console.WriteLine("==============================");
            Console.WriteLine(Traducoes.DEPOSITAR_VALOR);
            Console.WriteLine("==============================");
            Console.WriteLine(Traducoes.DIGITE_O_ID_DA_CONTA);
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(Traducoes.DIGITE_O_VALOR_A_SER_DEPOSITADO_NA_CONTA);
            double valor = double.Parse(Console.ReadLine());
            foreach (var conta in contasList)
            {
                if (conta.Id == id)
                {
                    conta.Depositar(valor);
                }
            }
            Console.WriteLine("==============================\n");
            Console.WriteLine(Traducoes.ESC_PARA_VOLTAR__);
            Console.ReadKey();
        }
    }
}