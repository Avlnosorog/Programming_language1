// Напишите программу, которая на входе принимает одно число N, а на выходе отображает все целые числа
// в промежутке от -N до N 
// numberNeg++ это тоже самое что numberNeg=numberNeg+1, то есть добавляется ещё один цикл
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Clear();
int numberNeg = number*(-1);

while(numberNeg <= number)
{
    Console.WriteLine(numberNeg);
    numberNeg++;
}
