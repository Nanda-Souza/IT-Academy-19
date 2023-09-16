using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criação de uma conta poupança
        //ContaPoupanca contaPoupanca = new ContaPoupanca(0.05m, new DateTime(2023, 7, 10), "Fernanda");

        // Depositar dinheiro na conta poupança
        //contaPoupanca.Depositar(3000);

        // Sacar dinheiro da conta poupança
        //contaPoupanca.Sacar(330);

        // Adicionar rendimento à conta poupança
        //contaPoupanca.AdicionarRendimento();

         //Imprimir informações da conta poupança
        //Console.WriteLine($"Titular: {contaPoupanca.Titular}");
        //Console.WriteLine($"Saldo da Conta: {contaPoupanca.Saldo:C}");
        //Console.WriteLine($"Taxa de Juros: {contaPoupanca.Juros:P}");
        //Console.WriteLine($"Data da Conta Poupança: {contaPoupanca.DataAniversario:dd/MM/yyyy}");
        //Console.WriteLine($"ID da Conta: {contaPoupanca.Id}");

        // Criação de uma coleção de objetos do tipo conta
        List<Conta> contas = new List<Conta>();

        ContaPoupanca conta1 = new ContaPoupanca(0.05m, new DateTime(2023, 7, 10), "Fernanda");
        ContaPoupanca conta2 = new ContaPoupanca(0.03m, new DateTime(2023, 8, 15), "Mariana");
        ContaPoupanca conta3 = new ContaPoupanca(0.03m, new DateTime(2023, 8, 15), "Camila");

        contas.Add(conta1);
        contas.Add(conta2);
        contas.Add(conta3);

        foreach (Conta conta in contas)
        {
            conta.Depositar(600); 
            conta.Sacar(400);      
        }

        // Acesso as propriedades das contas e contapoupanca.
        foreach (Conta conta in contas)
        {
            Console.WriteLine($"Titular: {conta.Titular}");
            Console.WriteLine($"Saldo da Conta: {conta.Saldo:C}");
        }

        Console.ReadLine();
    }
}
