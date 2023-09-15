using System;
using System.Drawing; // Importe o namespace System.Drawing

public class CirculoColorido : Circulo
{
    //private string Cor;

    //public string Cor
    //{
    //    get{return minhaCor;}
    //    set{minhaCor = value;}
    //}
    // public CirculoColorido()
    //{
    //    minhaCor = "preto";
    //}

    //public CirculoColorido(double x, double y, double r, string c)
    //    : base(x, y, r)
    //{
    //    minhaCor = c;
    //}

    //public override string ToString()
    //{
    //return base.ToString() + " cor=" + Cor;
    //}

    public Color Cor { get; set; } // Usamos Color para representar a cor

    public CirculoColorido()
    {
        Cor = Color.Black; // Cor padrão
    }

    public CirculoColorido(double x, double y, double r, Color c)
        : base(x, y, r)
    {
        Cor = c;
    }

    public override string ToString()
    {
        return base.ToString() + " cor=" + Cor.Name; // Name é o nome da cor
    }
}