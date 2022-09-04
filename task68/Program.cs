/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 3 n = 2 -> A(m,n) = 29*/


int AkkermanFunction(int m, int n)
{
    int ak;
    if (m == 0) ak = n + 1;
    else if (m > 0 && n == 0) ak = AkkermanFunction(m - 1, 1);
    else ak = AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return ak;
}

int result = AkkermanFunction(3, 2);
Console.WriteLine(result);