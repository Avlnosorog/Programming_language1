// Конвертируем Convert.ToInt32 переводим строковый тип данных в числовой
// Когда указываем в Console.WriteLine() текс русским алфавитом, то обязательно ставим его в кавычки ""
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int sqr = number*number;

Console.WriteLine("Квадрат данного числа");

Console.WriteLine(sqr);