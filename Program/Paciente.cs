using System;

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
        while (this.Nome == "")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInformação invalida digite novamente\n");
            Console.ResetColor();
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
        }

        Console.Write("CPF (11 dígitos): ");
        this.CPF = Console.ReadLine();
        while (this.CPF.Length != 11)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nInformação invalida digite novamente\n");
            Console.ResetColor();
            Console.Write("CPF(11 dígitos): ");
            this.CPF = Console.ReadLine();
        }

        Console.Write("Telefone (com DDD, apenas números): ");
        this.Telefone = Console.ReadLine();
        while (this.Telefone.Length != 11)
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