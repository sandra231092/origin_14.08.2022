Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int mod = numberA % numberB;

if (mod == 0)
{
    Console.Write("кратно");
}
else
{
    Console.Write($"не кратно, остаток {mod}");
}
