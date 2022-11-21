// Сумма чисел с рекурсией

int SumRec (int n)
{
    if (n == 1) return 1;
    else return n + SumRec(n-1);
}

Console.WriteLine("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());
int res = SumRec(num);
Console.WriteLine(res);
