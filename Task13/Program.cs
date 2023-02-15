Console.Write("Введите день недели цифрой: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 5)
{
    Console.WriteLine(number + " - этот день недели НЕ выходной ");
}
if (number > 5)
{
    Console.WriteLine(number + " - этот день недели является выходным ");
}