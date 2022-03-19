using System;

namespace ProjetoElevador.Model
{
    internal class Elevador
    {

        //Construtor sem parametros, apenas para inicializar todas as variaveis 
        public Elevador()
        {
            this.andarAtual = 0;
            this.totalAndares = 0;
            this.capacidadeElevador = 0;
            this.capacidadeAtual = 0;
        }

        //Variaveis utilizadas no programa.
        public int andarAtual { get; set; }
        public int totalAndares { get; set; }
        public int capacidadeElevador{ get; set; }
        public int capacidadeAtual { get; set; }
                

        //Método Inicializar:
        //Captura a capacidade máxima do elevador e o total de andares do prédio
        //através de mensagens amigáveis ao usuário.
        public void Inicializar()
        {
            Console.WriteLine(" Insira a capacidade máxima do elevador:");
            Console.Write(" Sua Opcao: ");
            capacidadeElevador = int.Parse(Console.ReadLine());

            Console.WriteLine(" Insira o total de andares do prédio:");
            Console.Write(" Sua Opcao: ");
            totalAndares = int.Parse(Console.ReadLine());

            Console.WriteLine("");
        }

        ///Método Entrar:
        //Método que adiciona uma pessoa ao elevador, desde que o mesmo
        //NÃO esteja na sua capacidade máxima
        //Caso esteja cheio, é exibida uma mensagem informando ao usuário deste fato.
        public void Entrar()
        {
            if(capacidadeAtual < capacidadeElevador)
            {
                capacidadeAtual++;
            }
            else
            {
                Console.WriteLine(" Não é possível entar. Elevador está cheio!");
            }
        }

        ///Método Sair:
        //Método que remove uma pessoa ao elevador, desde que o mesmo
        //NÃO esteja vazio
        //Caso esteja vazio, é exibida uma mensagem informando ao usuário deste fato.
        public void Sair()
        {
            if (capacidadeAtual > 0)
            {
                capacidadeAtual--;
            }
            else
            {
                Console.WriteLine(" Não é possível sair. Elevador está vazio!");
            }
        }


        ///Método Subir:
        //Método que sobe o elevador em um andar, desde que
        //NÃO esteja no ultimo andar (andar máximo)
        //Caso esteja no último andar, é exibida uma mensagem informando ao usuário deste fato.
        public void Subir()
        {
            if (andarAtual < totalAndares)
            {
                andarAtual++;
            }
            else
            {
                Console.WriteLine(" Não é possível subir outro andar. Elevador já está no topo do prédio!");
            }

        }

        ///Método Descer:
        //Método que desce o elevador em um andar, desde que
        //NÃO esteja no térreo (andar mínimo)
        //Caso esteja no terreo, é exibida uma mensagem informando ao usuário deste fato.
        public void Descer()
        {
            if (andarAtual > 0)
            {
                andarAtual--;
            }
            else
            {
                Console.WriteLine(" Não é possível descer outro andar. Elevador já está no térreo do prédio!");
            }
        }

        ///Método ToString:
        //Método que ao final da execução do programa,
        //imprime um "resumo" de onde o elevador parou (andar) e 
        //sua capacidade atual (pessoas), juntamente com a quantidade de andares máximos e capacidade máxima que foram inseridos pelo usuário.
        public override string ToString()
        {
            return ($"O Elevador do prédio de {totalAndares} andar/andares, com capacidade para {capacidadeElevador} pessoas, finalizou no andar de número {andarAtual} e com {capacidadeAtual} pessoa/pessoas dentro!");
        }

    }
}
