// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine ("Please input any number M ");
int M = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Please input any number N ");
int N = Convert.ToInt32 (Console.ReadLine());

int Summ= SumRange (M,N);
Console.WriteLine ("Sum of given range from M to N is " + Summ);

int SumRange ( int M, int N)
{
    if (M>N)
{
    return 0;
}
else 
{
    return M + SumRange(M+1, N);
}
}
