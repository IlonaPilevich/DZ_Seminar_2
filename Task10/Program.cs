Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = (number / 10 % 10);

Console.WriteLine("Исходное число: " + number + ", вторая цифра числа " + result);