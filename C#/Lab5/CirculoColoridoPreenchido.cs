using System;
using System.Drawing;

public class CirculoColoridoPreenchido : CirculoColorido
{
    public Color CorPreenchimento { get; set; }

    public CirculoColoridoPreenchido()
    {
        CorPreenchimento = Color.White; // Cor de preenchimento padrão
    }

    public CirculoColoridoPreenchido(double x, double y, double r, Color borda, Color preenchimento)
        : base(x, y, r, borda)
    {
        CorPreenchimento = preenchimento;
    }

    public override string ToString()
    {
        return base.ToString() + " cor preenchimento=" + CorPreenchimento.Name;
    }
}