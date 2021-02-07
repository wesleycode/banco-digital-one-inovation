using System;
using Banco.controller;
using Banco.Resources;

namespace Banco.view
{
    public class Menu
    {
        public Menu()
        {
            StartLoop();
        }

        private void FinalizarAplicacao()
        {
            Console.WriteLine("==============================");
            Console.WriteLine(Traducoes.APLICACAO_FINALIZADA_COM_SUCESSO);
            Console.WriteLine("==============================");
        }

        private string LerTeclado()
        {
            return Console.ReadLine().ToUpper();
        }
        public void LimparConsole()
        {
            Console.Clear();
        }
        private void MostrarMenuDeOpcoes()
        {
            LimparConsole();
            Console.WriteLine("==============================");
            Console.WriteLine(" Digital Inovation One Bank ");
            Console.WriteLine("==============================");
            Console.WriteLine(Traducoes.ENTRE_COM_A_OPCAO_DESEJADA);
            Console.WriteLine(Traducoes._1_LISTAR_TODAS_AS_CONTAS);
            Console.WriteLine(Traducoes._2_CRIAR_NOVA_CONTA);
            Console.WriteLine(Traducoes._3_TRANSFERIR);
            Console.WriteLine(Traducoes._4_SACAR);
            Console.WriteLine(Traducoes._5_DEPOSITAR);
            Console.WriteLine(Traducoes.X_SAIR);
        }

        private void StartLoop()
        {

            ContaController contaController = new ContaController();
            
            MostrarMenuDeOpcoes();
            string opcao = LerTeclado();
            
            while (opcao != "X")
            {
                LimparConsole();
                switch (opcao)
                {
                    case "1" : contaController.ListarContas(); break;
                    case "2" : contaController.InserirConta(); break;
                    case "3" : contaController.Transferir(); break;
                    case "4" : contaController.Sacar(); break;
                    case "5" : contaController.Depositar(); break;
                    default : LimparConsole() ; break;
                }
                MostrarMenuDeOpcoes();
                opcao = LerTeclado();
            }
            
            FinalizarAplicacao();
        }
    }
}