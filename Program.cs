Console.WriteLine("Введите  число");
int number = int.Parse(Console.ReadLine() ?? "");
int result = number * number;
Console.WriteLine("Результат возведения числа "+ number + " в квадрат это - " + result);//Конкатенация
Console.WriteLine($"Результат возведения числа {number} в квадрат это - {result}"); //Интерполяция

