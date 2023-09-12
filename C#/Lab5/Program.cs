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

        Circulo circ1 = new Circulo();
        Console.WriteLine("Círculo 1:");
        Console.WriteLine("CentroX: " + circ1.CentroX);
        Console.WriteLine("CentroY: " + circ1.CentroY);
        Console.WriteLine("Raio: " + circ1.Raio);
        Console.WriteLine();

        Circulo circ2 = new Circulo(2.4, 5, 3);
        Console.WriteLine("Círculo 2:");
        Console.WriteLine("CentroX: " + circ2.CentroX);
        Console.WriteLine("CentroY: " + circ2.CentroY);
        Console.WriteLine("Raio: " + circ2.Raio);
        Console.WriteLine();

        CirculoColorido circ3 = new CirculoColorido();
        Console.WriteLine("Círculo Colorido 3:");
        Console.WriteLine("CentroX: " + circ3.CentroX);
        Console.WriteLine("CentroY: " + circ3.CentroY);
        Console.WriteLine("Raio: " + circ3.Raio);
        Console.WriteLine("Cor: " + circ3.Cor);
        Console.WriteLine();

        CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
        Console.WriteLine("Círculo Colorido 4:");
        Console.WriteLine("CentroX: " + circ4.CentroX);
        Console.WriteLine("CentroY: " + circ4.CentroY);
        Console.WriteLine("Raio: " + circ4.Raio);
        Console.WriteLine("Cor: " + circ4.Cor);
    }
}