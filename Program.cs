using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSFila
{
    class Program
    {
        static void Main(string[] args)
        {

            string op;
            string auxNome;
            int j;
            int aux;


            Paciente P; //Objeto de instanciamento
            P = new Paciente();

            do // O Do..While (Faça..Enquanto/Continua) testa a condição só no final
            {

                //Opções

                Console.Clear(); // Limpa Tela
                Console.WriteLine("\n Programa: Fila de pacientes\n");
                Console.WriteLine("\n Digite uma opção: \n");
                Console.WriteLine("\n   -  -  -  -  -  -  -  -  - ");
                Console.WriteLine("\n |   (1) - CADASTRAR         |\n");
                Console.WriteLine("\n |   (2) - MOSTRAR FILA      |\n");
                Console.WriteLine("\n |   (3) - PROXIMO           |\n");
                Console.WriteLine("\n |   (Q) - SAIR DO PROGRAMA  |\n");
                Console.WriteLine("   -  -  -  -  -  -  -  -  - \n");

                op = Console.ReadLine();

                switch (op.ToUpper())

                /*ToUpper serve para deixar os valores
                maiusculos quando digitar a opção*/

                {

                    //Métodos dos Casos

                    case "1":
                        P.cadastrarDados();
                        P.cadastrarPrioridade();
                        break;
                    case "2":
                        P.mostraCase2();
                        break;
                    case "3":
                        P.mostraCase3();
                        break;
                    case "Q":
                        Console.WriteLine("\n Saindo...");
                        break;
                    default:
                        Console.WriteLine("\n Erro! Opção incorreta\n");
                        break;
                }

                if (P.i >= 1) //Ordenação da Fila
                {
                    for (P.cont = 0; P.cont < P.i - 1; P.cont++)
                    {
                        j = P.cont + 1;
                        while (j < P.i)
                        {
                            if (P.vet[P.cont].prioridade > P.vet[j].prioridade)
                            {
                                aux = P.vet[P.cont].prioridade;
                                P.vet[P.cont].prioridade = P.vet[j].prioridade;
                                P.vet[j].prioridade = aux;

                                auxNome = P.vet[P.cont].nome;
                                P.vet[P.cont].nome = P.vet[j].nome;
                                P.vet[j].nome = auxNome;
                            }
                            j++;
                        }
                    }
                }

                Console.ReadKey();
                Console.Clear();

            } while (op.ToUpper() != "Q"); // Condição para sair do programa

            //Final

            Console.Write("\n\n\n\n\n          - - - - - - - - - - - - - - - - ");
            Console.Write("\n\t |                               |");
            Console.Write("\n\n\t |                               |");
            Console.Write("\n\n\t |     Saindo do programa...     |");
            Console.Write("\n\n\t |                               |");
            Console.Write("\n\n\t |                               |");
            Console.WriteLine("\n          - - - - - - - - - - - - - - - - \n");
            Console.ReadKey();
        }
    }
}
