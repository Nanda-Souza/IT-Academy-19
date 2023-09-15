using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criação de uma conta poupança
        ContaPoupanca contaPoupanca = new ContaPoupanca(0.05m, new DateTime(2023, 7, 10), "Fernanda");

        // Depositar dinheiro na conta poupança
        contaPoupanca.Depositar(3000);

        // Sacar dinheiro da conta poupança
        contaPoupanca.Sacar(330);

        // Adicionar rendimento à conta poupança
        contaPoupanca.AdicionarRendimento();

         //Imprimir informações da conta poupança
        Console.WriteLine($"Titular: {contaPoupanca.Titular}");
        Console.WriteLine($"Saldo da Conta: {contaPoupanca.Saldo:C}");
        Console.WriteLine($"Taxa de Juros: {contaPoupanca.Juros:P}");
        Console.WriteLine($"Data da Conta Poupança: {contaPoupanca.DataAniversario:dd/MM/yyyy}");
        Console.WriteLine($"ID da Conta: {contaPoupanca.Id}");

        Console.ReadLine();
    }
}
