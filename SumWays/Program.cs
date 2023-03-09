int[,] matrix = new int[5, 5];
int[] suml = new int[5];
int[] sumc = new int[5];

Console.WriteLine("Informe os valores para a Matrix ");

//Entrada dos valores para matriz
for (int line = 0; line < 5; line++)
{
    for (int column = 0; column < 5; column++)
    {
        Console.Write("Matrix [{0}][{1}]: ", line , column);
        matrix[line, column] = int.Parse(Console.ReadLine());
    }
}

//Chamada das funções
for (int line = 0; line < matrix.GetLength(0); line++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        Console.Write("| " + matrix[line, column]);
    }
    Console.WriteLine(" |");
}
SumOfColumn(matrix);
SumOfLine(matrix);
SumDiagPrinc(matrix);
SumDiagSec(matrix);
int[] SumOfLine(int[,] m)
{
    for (int line = 0; line < 5; line++)
    {
        for (int column = 0; column < 5; column++)
        {
            suml[line] += matrix[line, column];
        }
        Console.WriteLine("A soma da linha " + line + " é " + suml[line]);
    }
    return suml;
}
int[] SumOfColumn(int[,] m)
{
    for (int column = 0; column < 5; column++)
    {
        for (int line = 0; line < 5; line++)
        {
            sumc[column] += m[line, column];
        }
        Console.WriteLine("A soma da coluna " + column + " é " + sumc[column]);
    }
    return sumc;
}
void SumDiagPrinc(int[,] matrix)
    //Função que calcula soma da diagonal principal e imprime
{
    int diagp = 0;
    for (int line = 0; line < matrix.GetLength(0); line++)
    {
        diagp += matrix[line, line];
        
    }
    Console.WriteLine("A soma da diagonal principal = " + diagp);
}
void SumDiagSec(int[,] matrix)
    //Função que soma diagonal secundaria e imprime
{
    int diagsec = 0;
    for (int line = 4; line >= matrix.GetLength(1)-5; line--)
    {
        diagsec += matrix[line, matrix.GetLength(0) - line - 1];
    }
    Console.WriteLine("A soma da diagonal secundária = " + diagsec);
}

//Leitura da matriz inteira com diagonal principal
//leitura = int.Parse(Console.ReadLine());
//suml += leitura;
//suml += leitura;
//if (line == column)
//{
//    suml += leitura;
//}
