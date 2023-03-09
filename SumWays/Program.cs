int[,] matrix = new int[5, 5];
int[] suml = new int[5];
int[] sumc = new int[5];

Console.WriteLine("Informe os valores para a Matrix ");
for (int line = 0; line < 5; line++)
{
    for (int column = 0; column < 5; column++)
    {
        Console.Write("Matrix [{0}][{1}]: ", line , column);
        matrix[line, column] = int.Parse(Console.ReadLine());
    }
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
    }
    return sumc;
}
void SumDiagPrinc(int[,] matrix)
{
    int diagp = 0;
    for (int line = 0; line < 5; line++)
    {
        for (int column = 0; column < 5; column++)
        {
            if (line == column)
            {
                diagp += matrix[line, column];
            }
        }
    }
    Console.WriteLine("A soma da diagonal principal = " + diagp);
}
void SumDiagSec(int[,] matrix)
{
    int diagsec = 0;
    for (int line = 4; line >= 0; line--)
    {
        diagsec += matrix[line, 4 - line];
    }
    Console.WriteLine("A soma da diagonal secundária = " + diagsec);
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("A soma da linha " + i + " é " + suml[i]);
    Console.WriteLine("A soma da coluna " + i + " é " + sumc[i]);
}

//Leitura da matriz inteira com diagonal principal
//leitura = int.Parse(Console.ReadLine());
//suml += leitura;
//suml += leitura;
//if (line == column)
//{
//    suml += leitura;
//}
