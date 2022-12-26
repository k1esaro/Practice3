const int n = 3;
int[] array1 = new int[n];
int[] array2 = new int[n];
void Input (ref int[] array)
{
    Console.Write("Введите координату x = ");
    array[0]= Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату y = ");
    array[1]= Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату z = ");
    array[2]= Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите координаты первой точки");
Input(ref array1);
Console.WriteLine("Введите координаты второй точки");
Input(ref array2);
double result = Math.Sqrt(Math.Pow(array1[0]-array2[0],2)+Math.Pow(array1[1]-array2[1],2)+Math.Pow(array1[2]-array2[2],2));
Console.Write("Расстояние между точками равно = ");
Console.Write(result);
