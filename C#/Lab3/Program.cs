using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{   
    private static void Main(string[] args)
    {   
        //Erro de compilação: Argument 1: cannot convert from 'int' to 'string'
        //List<string> listaStrings = new List<string>();
        //listaStrings.Add("Um"); 
        //listaStrings.Add("Hello");
        //listaStrings.Add("World");
        //Console.WriteLine(listaStrings[0]); 
        //Console.WriteLine(listaStrings[1]); 
        //Console.WriteLine(listaStrings[2]); 
        //listaStrings.Add(10);

        //Cria uma fila de objetos
        Queue<Object> q = new Queue<Object>();
        q.Enqueue(".Net Framework");
        q.Enqueue(new Decimal(123.456));
        q.Enqueue(654.321);
        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());

        //Cria uma fila de inteiros
        Queue<int> minhaFila = new Queue<int>(); 
        minhaFila.Enqueue(10); 
        minhaFila.Enqueue(200); 
        minhaFila.Enqueue(1000); 
        Console.WriteLine(minhaFila.Dequeue()); 
        Console.WriteLine(minhaFila.Dequeue()); 
        Console.WriteLine(minhaFila.Dequeue());

        //KeyValuePair<int, string>: 
        //obtem a lista de chave e seus respectivos valores armazenados no dicionário
        Dictionary<int, string> paises = new Dictionary <int, string>();
        paises[44] = "Reino Unido"; 
        paises[33] = "França"; 
        paises[55] = "Brasil"; 
        Console.WriteLine("O código 55 é: {0}", paises[55]);
        foreach (var item in paises)
            { 
            int codigo = item.Key;
            string pais = item.Value;
            Console.WriteLine("País {1} = {0}" , pais, codigo); 
            }

        //Recuperar o código DDI a partir do nome de um país
        Dictionary<string, int> paisesNew = new Dictionary<string, int>
        {
            {"Reino Unido", 44},
            {"França", 33},
            {"Brasil", 55},
        };

        Console.Write("Digite o nome do país: ");
        string nomePais = Console.ReadLine();

        if (paisesNew.TryGetValue(nomePais, out int codigoDDI))
        {Console.WriteLine("O código DDI para {0} é {1}", nomePais, codigoDDI);}
        else
        {Console.WriteLine("País não encontrado no dicionário.");}

        //Retorna os elementos em uma lista que são maiores do que a média de todos os elementos
        List<int> numbers = new List<int> { 2, 4, 6, 8 };
 
        double average = numbers.Average();
 
        Console.WriteLine("A media é {0}", average);
        
        List<int> averageList = new List<int> {};

        foreach (int i in numbers)
            { 
            if (i > average)
            averageList.Add(i);
            }
        
         string elementos = string.Join(", ", averageList);
         Console.WriteLine("Os valores maiores que a média são " + elementos);

         //Método TotalAcimaMedia
        List<double> numeros = new List<double> { 2, 4, 6, 8 };

        double media = CalcularMedia(numeros);
        int totalAcimaMedia = TotalAcimaMedia(numeros, media);

        Console.WriteLine("Números na lista: " + string.Join(", ", numeros));
        Console.WriteLine("Média dos números: " + media);
        Console.WriteLine("Total de números acima da média: " + totalAcimaMedia);

        static double CalcularMedia(List<double> numeros)
        {
            if (numeros.Count == 0)
            return 0;
            double soma = numeros.Sum();
            return soma / numeros.Count;
        }

        static int TotalAcimaMedia(List<double> numeros, double media)
        {
            int total = 0;
            foreach (double numero in numeros)
            {
                if (numero > media)
                 {total++;}
            }
            return total;
        }

         //Método ListaAcimaMedia
        List<double> num = new List<double> { 2, 4, 6, 8 };

        double med = CalcularMediaLi(num);
        List<double> listaAcimaMedia = NumerosAcimaMedia(num, med);

        Console.WriteLine("Números na lista: " + string.Join(", ", num));
        Console.WriteLine("Média dos números: " + med);
        Console.WriteLine("Lista de números acima da média são " + string.Join(", ", listaAcimaMedia));
    }

    static double CalcularMediaLi(List<double> num)
    {
        if (num.Count == 0)
            return 0;
        
        double soma = num.Sum();
        return soma / num.Count;
    }

    static List<double> NumerosAcimaMedia(List<double> num, double med)
    {
        List<double> numerosAcimaMedia = new List<double>();
        foreach (double numero in num)
        {
            if (numero > med)
            {numerosAcimaMedia.Add(numero);}
        }
        return numerosAcimaMedia;
    }   
}