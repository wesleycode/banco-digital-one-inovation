using System;
using System.Collections.Generic;
using Banco.model;
using Banco.view;

namespace Banco
{
    class Program
    {

        private static List<Conta> contasList = new List<Conta>();

        private static void ListarContas()
        {
            Menu.LimparConsole();
            Console.WriteLine("==============================");
            if (contasList.Count == 0)
            {
                Console.WriteLine(" Nenhum usuário cadastrado! ");
            }
            else
            {
                Console.WriteLine(" Contas cadastradas ");
                Console.WriteLine("==============================\n");
                foreach (var conta in contasList)
                {
                    Console.WriteLine("++++++++++++++++++++++++++++++");
                    Console.WriteLine("ID: " + conta.Id);
                    Console.WriteLine("NOME: " + conta.Nome);
                    Console.WriteLine("SALDO: " + conta.Saldo);
                    Console.WriteLine("TIPO DE CONTA: " + conta.TipoConta);
                    Console.WriteLine("++++++++++++++++++++++++++++++\n");
                }
                
            }
            Console.WriteLine("==============================\n");
            Console.WriteLine("Esc para Voltar..");
            Console.ReadKey();
        }
        private static void InserirConta()
        {
            Menu.LimparConsole();
            Console.WriteLine("==============================");
            Console.WriteLine(" Criar nova conta ");
            Console.WriteLine("==============================");
            Console.WriteLine(" Digite 1 Para Conta Fisica ou 2 Para conta Juridica: ");
            int tipoDeConta = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine(" Digite o saldo inicial: ");
            double saldo = Double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o crédito: ");
            double credito = Double.Parse(Console.ReadLine());

            int id = new Random().Next(99);
            
            contasList.Add(new Conta(id,nome,credito,saldo,(TipoConta) tipoDeConta));
        }
        private static void Transferir()
        {
            Menu.LimparConsole();
            Console.WriteLine("==============================");
            Console.WriteLine(" Transferir valor ");
            Console.WriteLine("==============================");
            Console.WriteLine(" Digite o ID da conta origem");
            int idOrigem = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o ID da conta destino");
            int idDestino = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o Valor a ser transferido ");
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
            Console.WriteLine("Esc para Voltar..");
            Console.ReadKey();
        }
        private static void Sacar()
        {
            Menu.LimparConsole();
            Console.WriteLine("==============================");
            Console.WriteLine(" Sacar valor ");
            Console.WriteLine("==============================");
            Console.WriteLine(" Digite o ID da conta");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o Valor a ser sacado da conta");
            double valor = double.Parse(Console.ReadLine());
            foreach (var conta in contasList)
            {
                if (conta.Id == id)
                {
                    conta.Sacar(valor);
                }
            }
            Console.WriteLine("==============================\n");
            Console.WriteLine("Esc para Voltar..");
            Console.ReadKey();
        }
        private static void Depositar()
        {
            Menu.LimparConsole();
            Console.WriteLine("==============================");
            Console.WriteLine(" Depositar valor ");
            Console.WriteLine("==============================");
            Console.WriteLine(" Digite o ID da conta");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o Valor a ser depositado na conta");
            double valor = double.Parse(Console.ReadLine());
            foreach (var conta in contasList)
            {
                if (conta.Id == id)
                {
                    conta.Depositar(valor);
                }
            }
            Console.WriteLine("==============================\n");
            Console.WriteLine("Esc para Voltar..");
            Console.ReadKey();
        }
        
        static void Main(string[] args)
        {
            
            Menu.MostrarMenuDeOpcoes();
            string opcao = Menu.LerTeclado();
            
            while (opcao != "X")
            {
                switch (opcao)
                {
                    case "1" : ListarContas(); break;
                    case "2" : InserirConta(); break;
                    case "3" : Transferir(); break;
                    case "4" : Sacar(); break;
                    case "5" : Depositar(); break;
                    default : Menu.LimparConsole() ; break;
                }
                Menu.MostrarMenuDeOpcoes();
                opcao = Menu.LerTeclado();
            }
            
            Menu.FinalizarAplicacao();
            
        }
    }
}