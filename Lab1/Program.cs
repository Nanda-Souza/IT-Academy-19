using System;
using System.Globalization;

internal class Program
{   
    private static void Main(string[] args)
    {
        //Valor máximo que pode ser armazenado em um byte
        byte b;
        b = byte.MaxValue;

        Console.WriteLine("Valor maximo de byte: " + b);

        //Valor máximo que pode ser armazenado em um int
        int i;
        i = int.MaxValue;

        Console.WriteLine("Valor maximo de int: " + i);

        //Valor máximo que pode ser armazenado em um long
        long l;
        l = long.MaxValue;

        Console.WriteLine("Valor maximo de long: " + l);
        
        //Concatenação das duas strings
        string strPrimeira = "Alo "; 
        string strSegunda = "Mundo";
        string strTerceira = strPrimeira + strSegunda;
        int cchTamanho = strTerceira.Length;

        Console.WriteLine(strTerceira);

        //Calculando o tamanho da string
        string strQuarta = "Tamanho = " + cchTamanho.ToString(); 
        
        Console.WriteLine(strQuarta);
        
        //Método String.Substring, remove uma parte de uma string
        Console.WriteLine(strTerceira.Substring(0, 5));

        //Método DateTime
        DateTime dt = new DateTime(2015, 04, 23);
        string strQuinta = dt.ToString();

        Console.WriteLine(strQuinta);

        //Diferenças float, double, e decimal
        float numberFloat = (10.1f);

        Console.WriteLine(numberFloat);

        double numberDouble = (10.9956666666666);

        Console.WriteLine(numberDouble);

        decimal numberDecimal = (10.89898989999999999999966m);

        Console.WriteLine(numberDecimal);
        
        //Criação de string com array de letras
        char[] chars = { 'i', 'n', 'u', '-', 'y', 'a', 's', 'h', 'a' };
        
        string string1 = new string(chars);
        Console.WriteLine(string1);

        //String repetida 30 vezes
        string string2 = new string('f', 30 );

        Console.WriteLine(string2);

        //String de formato personalizada que alinha os resultados e insere zeros à esquerda
        string format = "{0}) The {1} date and time is {2:MM/dd/yyyy hh:mm:ss tt}";

        //Criação DateTime maxima
        DateTime dt1 = new DateTime(DateTime.MaxValue.Ticks);

        //Criação DateTime minima
        DateTime dt2 = new DateTime(DateTime.MinValue.Ticks);

       //Criar um DateTime personalizado para 28/07/1977 às 22:35:05 usando um calendario "en-US"
       long ticks = new DateTime(1977, 07, 28, 22, 35, 5,
       new CultureInfo("en-US", false).Calendar).Ticks;
       DateTime dt3 = new DateTime(ticks);

       Console.WriteLine(format, 1, "maximum", dt1);
       Console.WriteLine(format, 2, "minimum", dt2);
       Console.WriteLine(format, 3, "custom ", dt3);
       Console.WriteLine("\nA data e hora personalizadas são criadas a partir de {0:N0} ticks.\n", ticks);

       float f = 0;
       //Conversão implícita, sem perda de dados
       f = i; 

       System.Console.WriteLine(f);

       //Conversão explícita, com perda de dados
       i = (int) f; 
      
       System.Console.WriteLine(i);
       
       //Métodos de conversão
       string stringInteiro = "123456789";
       int valorStringInteiro1 = Convert.ToInt32(stringInteiro);

       Console.WriteLine(valorStringInteiro1);

       Int64 valorInt641 = 123456789;
       int valorInt = Convert.ToInt32(valorInt641);

       Console.WriteLine(valorInt);

       //Teste método TryParse
       int valorStringInteiro;
       bool conversao1 = Int32.TryParse(stringInteiro, out valorStringInteiro);

       Console.WriteLine("Conversão efetuada:" + conversao1 + " Valor: " + valorStringInteiro);

       string stringInteiroGrande = "999999999999999999999999999999999999999999999";
       int valorStringInteiroGrande;
       bool conversao2 = Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande);

       Console.WriteLine("Conversão efetuada:" + conversao2 + " Valor: " + valorStringInteiroGrande);
        
       string stringLetras = "abc";
       double valorStringLetras;
       bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);

       Console.WriteLine("Conversão efetuada:" + conversao3 + " Valor: " + valorStringLetras);

       //Arredondamento de valores
       double valorFracionado = 4.7;
       int valorInteiro1 = (int) valorFracionado;
       int valorInteiro2 = Convert.ToInt32(valorFracionado);
       Console.WriteLine("Conversao explicita = " + valorInteiro1);
       Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);

        int x = 10;
        double y = 3.4;
         //Imprimi os valores declarados para x e y no console, primeiro x e depois y, conforme a posição do indice
        Console.WriteLine("{0} {1}", x,y);
        //Interpolação de strings
        Console.WriteLine($"{x} {y}");

    }

}
