// Важно!После if знак   ;   не ставится
Console.WriteLine("Введите 2 числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if ( a > b)
{
    Console.WriteLine(" Первое число " + a + " больше, чем второе " + b );
}

else

{
    Console.WriteLine(" Второе число " + b + " больше, чем первое " + a);
}
