internal class Program
{   
    private static void Main(string[] args)
    {   
   ContaCorrente minhaConta = new ContaCorrente(340, "Fernanda Oliveira"); 
   
   Console.WriteLine($"Saldo Anterior Depositar 100: {minhaConta.Saldo}"); 
   minhaConta.Depositar(100); 
   minhaConta.Sacar(100); 
   minhaConta.Depositar(100);
      
   
   Console.WriteLine($"Saldo: {minhaConta.Saldo}");
   Console.WriteLine($"Titular: {minhaConta.NomeTitular}");
   Console.WriteLine($"Data de Criação: {minhaConta.DataCriacao}");

   Console.WriteLine($"Saldo Médio: {minhaConta.SaldoMedio}");
 }
}