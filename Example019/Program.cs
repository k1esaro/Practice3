Console.Write("Введите пятизначное число  ");
int number = Convert.ToInt32(Console.ReadLine());
int k1 = number/10000;
int k2 = number/1000 - k1 * 10;
int k3 = number/100 - k2 * 10 - k1*100;
int k4 = number/10 - k3 * 10 - k2 * 100 - k1 * 1000;
int k5 = number%10;
if (k1==k5 && k2 == k4)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не является");
}
