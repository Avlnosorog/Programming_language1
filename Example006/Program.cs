Console.WriteLine("Введите трёхзначное число");

int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 || number > 999)
{
    Console.WriteLine("Это не трёхзначное число, введите новое значение");
}
else
{
int a = number%10;
Console.WriteLine("последняя цифра данного числа " +a);
}