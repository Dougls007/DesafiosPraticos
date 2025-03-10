using System;

class Program
{
    static void Main()
    {
        // 1. Mensagem de Boas-Vindas Personalizada
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!\n");

        // 2. Concatenar Nome e Sobrenome
        Console.Write("Digite seu nome: ");
        string nome2 = Console.ReadLine();
        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();
        string nomeCompleto = nome2 + " " + sobrenome;
        Console.WriteLine("Nome completo: " + nomeCompleto + "\n");

        // 3. Operações com Dois Números Double
        double num1 = 10.5;
        double num2 = 5.2;

        double soma = num1 + num2;
        double subtracao = num1 - num2;
        double multiplicacao = num1 * num2;
        double divisao = num2 != 0 ? num1 / num2 : 0;
        double media = (num1 + num2) / 2;

        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Subtração: " + subtracao);
        Console.WriteLine("Multiplicação: " + multiplicacao);
        Console.WriteLine("Divisão: " + divisao);
        Console.WriteLine("Média: " + media + "\n");

        // 4. Contar Caracteres de uma Palavra
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        int quantidadeCaracteres = palavra.Length;
        Console.WriteLine("A palavra tem " + quantidadeCaracteres + " caracteres.\n");

        // 5. Validar Placa de Veículo (Padrão até 2018) - Sem Regex
        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();

        bool valida = placa.Length == 7 && // Verifica se tem 7 caracteres
                      char.IsLetter(placa[0]) && // Verifica se o primeiro caractere é letra
                      char.IsLetter(placa[1]) && // Verifica se o segundo caractere é letra
                      char.IsLetter(placa[2]) && // Verifica se o terceiro caractere é letra
                      char.IsDigit(placa[3]) && // Verifica se o quarto caractere é número
                      char.IsDigit(placa[4]) && // Verifica se o quinto caractere é número
                      char.IsDigit(placa[5]) && // Verifica se o sexto caractere é número
                      char.IsDigit(placa[6]); // Verifica se o sétimo caractere é número

        Console.WriteLine(valida ? "Verdadeiro" : "Falso" + "\n");

        // 6. Exibir Data em Diferentes Formatos
        DateTime dataAtual = DateTime.Now;

        // Formato completo
        Console.WriteLine("Formato completo: " + dataAtual.ToString("F"));

        // Apenas a data
        Console.WriteLine("Apenas a data: " + dataAtual.ToString("dd/MM/yyyy"));

        // Apenas a hora
        Console.WriteLine("Apenas a hora: " + dataAtual.ToString("HH:mm:ss"));

        // Data com mês por extenso
        Console.WriteLine("Data com mês por extenso: " + dataAtual.ToString("dd MMMM yyyy"));
    }
}