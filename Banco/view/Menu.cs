using System;

namespace Banco.view
{
    public class Menu
    {

        private static bool ValidarEscolhaDoUsuario(string valor)
        {
            if (!int.TryParse(valor, out int value) || valor.Length != 1)
            {
                return false;
            }
            return true;
        }
        
        public static void FinalizarAplicacao()
        {
            Console.WriteLine("==============================");
            Console.WriteLine(" Aplicação Finalizada Com Sucesso ");
            Console.WriteLine("==============================");
        }

        public static string LerTeclado()
        {
            return Console.ReadLine().ToUpper();
        }
        public static void LimparConsole()
        {
            Console.Clear();
        }
        public static void MostrarMenuDeOpcoes()
        {
            LimparConsole();
            Console.WriteLine("==============================");
            Console.WriteLine(" Digital Inovation One Bank ");
            Console.WriteLine("==============================");
            Console.WriteLine(" Informe a opção desejada: ");
            Console.WriteLine(" 1 - Listar Todas as Contas ");
            Console.WriteLine(" 2 - Inserir Nova Conta ");
            Console.WriteLine(" 3 - Transferir Dinheiro ");
            Console.WriteLine(" 4 - Sacar Dinheiro ");
            Console.WriteLine(" 5 - Depositar Dinheiro ");
            Console.WriteLine(" 6 - Limpar Tela ");
            Console.WriteLine(" X - Sair ");
        }
    }
}