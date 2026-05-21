using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Paciente
{
    public string Nome;
    public string CPF;
    public string Telefone;
    public string Email;
    public string Sexo;
    public string DataNascimento;

    public virtual void Cadastrar()
    {
        Console.Write("Nome: ");
        this.Nome = Console.ReadLine();
        while (this.Nome == "" || this.Nome.Any(char.IsDigit))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInformação invalida digite novamente\n");
            Console.ResetColor();
            Console.Write("Nome: ");
            this.Nome = Console.ReadLine();
        }

        Console.Write("CPF Ex: 47847847844 (11 dígitos): ");
        this.CPF = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(this.CPF) ||
            (this.CPF.Length != 11) || 
            this.CPF == new string(this.CPF[0], 11) || 
            (this.CPF.Contains("-") && this.CPF.IndexOf('-') == 0 && !this.CPF.Contains(".")))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInformação invalida digite novamente (Sem Pontuação ou Espaços)...\n");
            Console.ResetColor();
            Console.Write("CPF(11 dígitos): ");
            this.CPF = Console.ReadLine();
        }


        Console.Write("Telefone (com DDD, apenas números): ");
        this.Telefone = Console.ReadLine();
        while (this.Telefone.Length != 11 || (this.Telefone.Contains("-") && this.Telefone.IndexOf('-') == 0 && !this.Telefone.Contains(".")))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInformação invalida digite novamente\n");
            Console.ResetColor();
            Console.Write("Telefone (com DDD, apenas números): ");
            this.Telefone = Console.ReadLine();
        }

        Console.Write("Digite o E-mail: ");
        this.Email = Console.ReadLine();
        while (this.Email.Contains("@") != true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInformação invalida digite novamente\n");
            Console.ResetColor();
            Console.Write("Digite o E-mail: ");
            this.Email = Console.ReadLine();
        }


        Console.Write("Sexo(M / F): ");
        this.Sexo = Console.ReadLine().ToUpper();
        while (this.Sexo != "M" && this.Sexo != "F")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInformação invalida digite novamente\n");
            Console.ResetColor();
            Console.Write("Sexo (M/F): ");
            this.Sexo = Console.ReadLine().ToUpper();
        }


        Console.Write("Data de Nascimento (Ex: 23/04/2026): ");
        this.DataNascimento = Console.ReadLine();
        while (this.DataNascimento == "" || !DateTime.TryParse(this.DataNascimento, out _))


        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInformação invalida digite novamente\n");
            Console.ResetColor();

            Console.Write("Data de nascimento (Ex: 23/04/2026): ");
            this.DataNascimento = Console.ReadLine();
        }
    }

    public virtual void MostrarDados()
    {
        Console.WriteLine($"\n--- Dados Cadastrados ---");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine($"Telefone: {Telefone}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Data de Nascimento: {DataNascimento}");
    }
}