using System;
class ContaCorrente {

private decimal saldo;
private decimal totalOperacoes;
private DateTime dataCriacao;
private string nomeTitular;
private List<decimal> operacoes = new List<decimal>(); 

private int numOperacoes = 0;


public void Depositar(decimal val)
{
    saldo = saldo + val;
    operacoes.Add(saldo);
    numOperacoes++;
}

public void Sacar(decimal val)
{
    saldo = saldo - val;
    operacoes.Add(saldo);
    numOperacoes++;
}

public decimal Saldo { get { return saldo; } }

public void CalculaSaldoMedio()
{
    totalOperacoes = operacoes.Sum();
}

public decimal SaldoMedio 
{ 
    set { totalOperacoes = operacoes.Sum();}
    get { return totalOperacoes; } 
}

public DateTime DataCriacao
    {
        get { return dataCriacao; }
        set { dataCriacao = value; }
    }
public string NomeTitular
    {
        get { return nomeTitular; }
        set { nomeTitular = value; }
    }

public ContaCorrente(decimal val, string titular)
    {
        saldo = val;
        dataCriacao = DateTime.Now;
        nomeTitular = titular;
    }
}