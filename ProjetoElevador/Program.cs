using System;
using ProjetoElevador.Model;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A variavel operacaoUsuario é utilizada no menu interativo para capturar qual ação a ser realizada
            //A variavel validaOperacoes é utilizada também no menu interativo para capturar apenas a ação de término do programa.
            string operacaoUsuario;
            bool validaOperacoes = true;

            //Variavel elevador sendo instanciada para podermos utilizar seus métodos.
            Elevador elevador = new Elevador();

            //Aqui é chamado o método Inicializar() que captura a capacidade do elevador e a quantidade de andares do prédio
            elevador.Inicializar();

            //Aqui começa o menu interativo, que será sempre repetido até que o usuario escolha a opção 5, que finaliza o programa.
            do
            {
                Console.WriteLine(" Escolha uma opção:");
                Console.WriteLine(" 1 - Entrar no Elevador");
                Console.WriteLine(" 2 - Sair do Elevador");
                Console.WriteLine(" 3 - Subir Andar");
                Console.WriteLine(" 4 - Descer Andar");
                Console.WriteLine(" 5 - Finalizar Programa");

                Console.Write(" Sua Opcao: ");
                operacaoUsuario = Console.ReadLine();
                Console.Clear();

                //Esse escolha determina qual operação será utilizada a partir da entrada do usuário acima, através da variavel operacaoUsuario.
                switch (operacaoUsuario)
                {
                    case "1": Console.WriteLine(" Você escolheu: Entrar"); elevador.Entrar(); break;
                    case "2": Console.WriteLine(" Você escolheu: Sair"); elevador.Sair(); break;
                    case "3": Console.WriteLine(" Você escolheu: Subir"); elevador.Subir(); break;
                    case "4": Console.WriteLine(" Você escolheu: Descer"); elevador.Descer(); break;
                    case "5": validaOperacoes = false; break;
                    default: Console.WriteLine("Escolha não válida."); break;
                }
                Console.WriteLine("");
            }

            while (validaOperacoes);

            //Após o usuário decidir terminar a execução do programa, é impresso na tela o andar que o elevador ficou e a quantidade de pessoas dentro dele.
            Console.WriteLine(elevador.ToString());
            
        }

    }
}