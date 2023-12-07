// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine ("Please input  number M above zero ");
int M = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Please input  number N above zero ");
int N = Convert.ToInt32 (Console.ReadLine());


int result= Akkerman (M,N);
Console.WriteLine ("Akkerman result is  " + result);

int Akkerman ( int M, int N)
{
    if (M==0)
{
    return N+1;
}
else if (M>0 && N==0)
{
return Akkerman (M-1,1);
}
else if (M>0 && N>0)
{
    return Akkerman (M-1, Akkerman (M, N-1));
}
else 
{
    return 0;
}
}
