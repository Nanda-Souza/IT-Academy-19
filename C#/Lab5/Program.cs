using System;
using System.Drawing;

internal class Program
{   
    private static void Main(string[] args)
    {
        //Circulo circ1 = new Circulo();
        //Console.WriteLine(circ1);
        //Circulo circ2 = new Circulo(2.4, 5, 3);
        //Console.WriteLine(circ2);
        //CirculoColorido circ3 = new CirculoColorido();
        //Console.WriteLine(circ3);
        //CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
        //Console.WriteLine(circ4);


        //Circulo circ1 = new Circulo();
        //Console.WriteLine("Círculo 1:");
        //Console.WriteLine("CentroX: " + circ1.CentroX);
        //Console.WriteLine("CentroY: " + circ1.CentroY);
        //Console.WriteLine("Raio: " + circ1.Raio);
        //Console.WriteLine();

        //Circulo circ2 = new Circulo(2.4, 5, 3);
        //Console.WriteLine("Círculo 2:");
        //Console.WriteLine("CentroX: " + circ2.CentroX);
        //Console.WriteLine("CentroY: " + circ2.CentroY);
        //Console.WriteLine("Raio: " + circ2.Raio);
        //Console.WriteLine();

        //CirculoColorido circ3 = new CirculoColorido();
        //Console.WriteLine("Círculo Colorido 3:");
        //Console.WriteLine("CentroX: " + circ3.CentroX);
        //Console.WriteLine("CentroY: " + circ3.CentroY);
        //Console.WriteLine("Raio: " + circ3.Raio);
        //Console.WriteLine("Cor: " + circ3.Cor);
        //Console.WriteLine();

        //CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
        //CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, Color.FromName("vermelho"));
        //CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, Color.Red);
        //Console.WriteLine("Círculo Colorido 4:");
        //Console.WriteLine("CentroX: " + circ4.CentroX);
        //Console.WriteLine("CentroY: " + circ4.CentroY);
        //Console.WriteLine("Raio: " + circ4.Raio);
        //Console.WriteLine("Cor: " + circ4.Cor);

        //CirculoColoridoPreenchido circuloPreenchido = new CirculoColoridoPreenchido(2.0, 2.0, 2.0, Color.Blue, Color.Yellow);
        //Console.WriteLine("Círculo Colorido Preenchido:");
        //Console.WriteLine("CentroX: " + circuloPreenchido.CentroX);
        //Console.WriteLine("CentroY: " + circuloPreenchido.CentroY);
        //Console.WriteLine("Raio: " + circuloPreenchido.Raio);
        //Console.WriteLine("Cor Borda: " + circuloPreenchido.Cor.Name);
        //Console.WriteLine("Cor Preenchimento: " + circuloPreenchido.CorPreenchimento.Name);

          // Criação do array
        Circulo[] circulos = new Circulo[3];

        circulos[0] = new Circulo(2.0, 2.0, 1.0);
        circulos[1] = new CirculoColorido(3.0, 3.0, 2.0, Color.Blue);
        circulos[2] = new CirculoColoridoPreenchido(4.0, 4.0, 1.5, Color.Green, Color.Yellow);

        // Percorr o array e imprima os objetos
        foreach (Circulo circulo in circulos)
        {
            Console.WriteLine("Tipo: " + circulo.GetType().Name);
            Console.WriteLine("CentroX: " + circulo.CentroX);
            Console.WriteLine("CentroY: " + circulo.CentroY);
            Console.WriteLine("Raio: " + circulo.Raio);

            if (circulo is CirculoColorido)
            {
                CirculoColorido circuloColorido = (CirculoColorido)circulo;
                Console.WriteLine("Cor: " + circuloColorido.Cor.Name);
            }

            if (circulo is CirculoColoridoPreenchido)
            {
                CirculoColoridoPreenchido circuloPreenchido = (CirculoColoridoPreenchido)circulo;
                Console.WriteLine("Cor Borda: " + circuloPreenchido.Cor.Name);
                Console.WriteLine("Cor Preenchimento: " + circuloPreenchido.CorPreenchimento.Name);
            }

            Console.WriteLine();
        }
    }
}