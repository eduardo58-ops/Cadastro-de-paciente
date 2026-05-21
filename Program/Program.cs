using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente pac1 = new Paciente();
            bool deveContinuar = true;
            while (deveContinuar)
            {
                Console.WriteLine("  ┌──────────────────────────────────┐");
                Console.WriteLine("  │        SISTEMA HOSPITALAR        │");
                Console.WriteLine("  │                                  │");
                Console.WriteLine("  │       SELECIONE UMA OPÇÃO        │");
                Console.WriteLine("  ├──────────────────────────────────┤");
                Console.WriteLine("  │       CADASTRAR NOVO             │");
                Console.WriteLine("  ├──────────────────────────────────┤");
                Console.WriteLine("  │       [1] Paciente               │");
                Console.WriteLine("  ├──────────────────────────────────┤");
                Console.WriteLine("  │       EXIBIR                     │");
                Console.WriteLine("  ├──────────────────────────────────┤");
                Console.WriteLine("  │       [2] Fila                   │");
                Console.WriteLine("  ├──────────────────────────────────┤");
                Console.WriteLine("  │       ATENDER                    │");
                Console.WriteLine("  ├──────────────────────────────────┤");
                Console.WriteLine("  │       [3] Chamar o proximo       │");
                Console.WriteLine("  ├──────────────────────────────────┤");
                Console.WriteLine("  │                                  │");
                Console.WriteLine("  │       APERTE 'Q' PARA SAIR       │");
                Console.WriteLine("  │                                  │");
                Console.WriteLine("  └──────────────────────────────────┘\n");
                string opcao = Console.ReadLine();
                Console.Clear();

                while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "q")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida, digite novamente\n");
                    Console.ResetColor();

                    Console.WriteLine("  ┌──────────────────────────────────┐");
                    Console.WriteLine("  │        SISTEMA HOSPITALAR        │");
                    Console.WriteLine("  │                                  │");
                    Console.WriteLine("  │       SELECIONE UMA OPÇÃO        │");
                    Console.WriteLine("  ├──────────────────────────────────┤");
                    Console.WriteLine("  │       CADASTRAR NOVO             │");
                    Console.WriteLine("  ├──────────────────────────────────┤");
                    Console.WriteLine("  │       [1] Paciente               │");
                    Console.WriteLine("  ├──────────────────────────────────┤");
                    Console.WriteLine("  │       EXIBIR                     │");
                    Console.WriteLine("  ├──────────────────────────────────┤");
                    Console.WriteLine("  │       [2] Fila                   │");
                    Console.WriteLine("  ├──────────────────────────────────┤");
                    Console.WriteLine("  │       ATENDER                    │");
                    Console.WriteLine("  ├──────────────────────────────────┤");
                    Console.WriteLine("  │       [3] Chamar o proximo       │");
                    Console.WriteLine("  ├──────────────────────────────────┤");
                    Console.WriteLine("  │                                  │");
                    Console.WriteLine("  │       APERTE 'Q' PARA SAIR       │");
                    Console.WriteLine("  │                                  │");
                    Console.WriteLine("  └──────────────────────────────────┘\n");
                    opcao = Console.ReadLine();
                    Console.Clear();
                }

                if (opcao == "1")
                {
                    Console.WriteLine("          ┌────────────────────────────────────┐");
                    Console.WriteLine("          │     NOVO REGISTRO: PACIENTE        │");
                    Console.WriteLine("          └────────────────────────────────────┘\n");
                    pac1.Cadastrar();
                    pac1.MostrarDados();
                    Console.WriteLine("\nCadastro realizado com sucesso!");
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("          ┌────────────────────────────────────┐");
                    Console.WriteLine("          │       EXIBIR: FILA DE ATENDIMENTO  │");
                    Console.WriteLine("          └────────────────────────────────────┘\n");
                    if (!string.IsNullOrWhiteSpace(pac1.Nome))
                    {
                        pac1.MostrarDados();
                    }
                    else
                    {
                        Console.WriteLine("Nenhum paciente na fila no momento.");
                    }
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("          ┌────────────────────────────────────┐");
                    Console.WriteLine("          │            ATENDIMENTO             │");
                    Console.WriteLine("          └────────────────────────────────────┘\n");
                    if (!string.IsNullOrWhiteSpace(pac1.Nome))
                    {
                        Console.WriteLine($"Chamando o próximo paciente: {pac1.Nome} para atendimento!");
                        pac1 = new Paciente();
                    }
                    else
                    {
                        Console.WriteLine("Nenhum paciente aguardando atendimento.");
                    }
                }
                else if (opcao == "q")
                {
                    Console.WriteLine("\nTem certeza que quer sair? Caso não, o programa voltará a pagina inicial (S/N)");
                    string resposta = Console.ReadLine().ToUpper();
                    while (resposta != "S" && resposta != "N")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nResposta inválida, digite novamente (S/N)\n");
                        Console.ResetColor();
                        resposta = Console.ReadLine().ToUpper();
                    }
                    if (resposta == "S")
                    {
                        deveContinuar = false;
                        Console.WriteLine("\nObrigado por usar o sistema de gestão de academia!");
                    }
                    else
                    {
                        Console.Clear();
                    }
                }

                Console.ReadKey();
                Console.Clear();

                if (opcao == "1" || opcao == "2" || opcao == "3")
                {
                    Console.WriteLine("\nTem certeza que quer sair? Caso não, o programa voltará a pagina inicial (S/N)");
                    string resposta = Console.ReadLine().ToUpper();
                    while (resposta != "S" && resposta != "N")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nResposta inválida, digite novamente (S/N)\n");
                        Console.ResetColor();
                        resposta = Console.ReadLine().ToUpper();
                    }
                    if (resposta == "S")
                    {
                        deveContinuar = false;
                        Console.WriteLine("\nObrigado por usar o sistema de gestão de academia!");
                    }
                    else
                    {
                        Console.Clear();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
