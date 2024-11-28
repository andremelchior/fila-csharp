using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFila
{
    class Paciente
    {
        public string nome;
        public int prioridade;
        private string Prioridade;

        public int i = 0;
        public int cont;
        int posicao;

        public Paciente[] vet = new Paciente[10];

        //Caso 01
        public void cadastrarDados()
        {
            if (i <= 9) // Condição para limitar o número de pacientes na fila
            {
                Console.Clear();
                Console.WriteLine("\n Digite o seu nome: \n");
                this.nome = Console.ReadLine();
                while (this.nome == "") // Enquato o nome estiver vazio, vai repetir a condição dentro do laço
                {
                    if (this.nome == "") // Se o nome estiver vazio, o usuario digita novamente
                    {
                        Console.WriteLine("      Erro! \n");
                        Console.WriteLine("\n Você não preencheu o seu nome! Digite novamente.\n");
                        this.nome = Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("\nA fila está cheia! espere o próximo ser chamado.");
            }
        }

        public void cadastrarPrioridade()
        {
            if (i <= 9) // Condição para limitar o número de pacientes na fila
            {

                // Digitar a prioridade

                Console.Clear();
                Console.WriteLine("\n Digite uma forma de atendimento: \n");
                Console.WriteLine("\n (1) - ATENDIMENTO PREFERENCIAL \n");
                Console.WriteLine(" (2) - ATENDIMENTO NORMAL \n");
                this.Prioridade = Console.ReadLine();

                if (this.Prioridade == "1" || this.Prioridade == "2")

                /*Se a prioridade for 1 ou 2, o vetor na posição i vira
                um novo objeto da classe e recebe a prioridade e o nome no vetor*/

                {
                    vet[i] = new Paciente();
                    vet[i].prioridade = int.Parse(this.Prioridade);
                    vet[i].nome = this.nome;
                    i++; //incremento
                }
                else
                {
                    Console.WriteLine("\n Erro! opção incorreta\n");
                }
            }
        }

        //Caso 02
        public void mostraCase2()
        {
            if (i >= 1)
            {
                for (cont = 0; cont < i; cont++)
                {
                    posicao = cont + 1; //Guarda a posição do paciente
                    if (vet[cont].prioridade == 1)

                    /* Se a prioridade for preferencial,
                    a condição é testada primeiro para visualizar */

                    {
                        // Mostra a posição e o nome do paciente preferencial
                        Console.WriteLine("\n " + posicao + "º Atendimento Preferencial: " + vet[cont].nome);
                    }
                    else // Senão mostra o atendimento normal 
                    {
                        // Mostra a posição e o nome do paciente normal
                        Console.WriteLine("\n " + posicao + "º Atendimento Normal: " + vet[cont].nome);
                    }
                }
            }
            else
            {
                Console.WriteLine("\n A fila está vázia, cadastre o próximo!");
            }
        }

        //Caso 03
        public void mostraCase3()
        {
            if (i >= 1)
            {
                if (vet[0].prioridade == 1) // Exibindo o primeiro da fila
                {
                    Console.WriteLine("\n1º Atendimento Preferencial: " + vet[0].nome);
                }
                else
                {
                    Console.WriteLine("\n1º Atendimento Normal: " + vet[0].nome);
                }

                for (cont = 0; cont < i - 1; cont++)// Fazendo a fila andar tirando o primeiro paciente
                {
                    posicao = cont + 1;
                    vet[cont].prioridade = vet[posicao].prioridade;
                    vet[cont].nome = vet[posicao].nome;
                }
                i--; //decremento
            }
            else
            {
                Console.WriteLine("\n A fila está vázia, cadastre o próximo!");
            }
        }
    }
}
