int number = new Random().Next(10, 100);
int digit2 = number % 10;
int digit1 = number / 10;
if (digit1 > digit2)
{
    Console.Write(digit1);
}
else
{
    Console.Write(digit2);
}
Console.WriteLine (" - наибольшая цифра");