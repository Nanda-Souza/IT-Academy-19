internal class Program
{   
    private static void Main(string[] args)
    {
        int[] array = new int[5] { 10, 20, 30, 40, 50 };
        int i;
        for (i = 0; i < 5; i++)
        {Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);}

        int feNum = 0;
        foreach (int a in array)

        {Console.WriteLine("Índice = " + feNum + " & Valor = " + a); feNum++;}

        string[] str = new string[3];
        int iStr;
        str[0] = "Um";
        str[1] = "Dois";
        str[2] = "Tres";
        for (iStr = 0; iStr < 3; iStr++)

        {Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);}

        int iStrn = 0;
        foreach (string a in str)

        {Console.WriteLine("Indice = " + iStrn + " & Valor = " + a); iStrn++;}

        DateTime[] dt = new DateTime[2];
        int iDate;
        dt[0] = new DateTime(2002, 5, 1);
        dt[1] = new DateTime(2002, 6, 1);
        for (iDate = 0; iDate < 2; iDate++)

        {Console.WriteLine("Indice = " + iDate + " & Data = " + dt[iDate].ToShortDateString());}

        int iData = 0;
        foreach (DateTime a in dt)

        {Console.WriteLine("Indice = " + iData + " & Data = " + a.ToShortDateString()); iData++;}

        //int[] array = new int[5] { 10, 20, 30, 40, 50 };
        int[] arrayUm = new int[100];
        arrayUm[0] = 1;
        arrayUm[1] = 2;
        arrayUm[2] = 3;

        for (int b = 0; b < arrayUm.Length; b++)

        {Console.WriteLine("Array " + b + ": " + arrayUm[b]);}

        int[] arrayDois = new int[100];
        
        //Metodo do .Net
        // Array.Copy(arrayUm, arrayDois, arrayUm.Length);

        // Verifique o conteúdo do arrayDois após a cópia
        //for (int c = 0; c < arrayDois.Length; c++)

        //{Console.WriteLine("ArrayDois " + c + ": " + arrayDois[c]);}

        //Metodo com for 
        for (int d = 0; d < arrayUm.Length; d++)
        {arrayDois[d] = arrayUm[d];}

        // Verifique o conteúdo do arrayDois após a cópia
        for (int d = 0; d < arrayDois.Length; d++)

       {Console.WriteLine("ArrayDois " + d + ": " + arrayDois[d]);}
       
        //Array multidimensional

       int[,] matrizCinco = { { 1, 2, 3, 4, 5 }, 
                              { 1, 2, 3, 4, 5 }, 
                              { 1, 2, 3, 4, 5 }, 
                              { 1, 2, 3, 4, 5 }, 
                              { 1, 2, 3, 4, 5 } };

       int numLinhas = matrizCinco.GetLength(0); 
       int numColunas = matrizCinco.GetLength(1);         

       int[] colunaSoma = new int[numColunas];              
                          
       for (int coluna = 0; coluna < numColunas; coluna++){

       for (int linha = 0; linha < numLinhas; linha++)

       {colunaSoma[coluna] += matrizCinco[linha, coluna];}
       }

       for (int coluna = 0; coluna < numColunas; coluna++)

      {Console.WriteLine("Soma de Colunas " + coluna + ": " + colunaSoma[coluna]);}

      //Notação para matriz jagged: int[][] matrizJagged = new int[5][]
    }
}
