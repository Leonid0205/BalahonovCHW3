//Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.

void Polindrom(int num5)
{
    if(num5/10000 == num5%10 && (num5/1000)%10 == (num5%100)/10)
    {
        Console.WriteLine($"The {num5} is polindrom)");
    }
    else Console.WriteLine($"The muber is not a polindrom!");
}
Console.WriteLine("Input five digit number: ");
int num5 = Convert.ToInt32(Console.ReadLine());
Polindrom(num5);
Console.WriteLine();

//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

double DistanceBetweenAB(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double disab = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return disab;
}
Console.WriteLine("Input X coordinate for dot A: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input X coordinate for dot B: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinate for dot A: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinate for dot B: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinate for dot A: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinate for dot B: ");
double z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Distance between A and B is " + DistanceBetweenAB(x1,y1,z1,x2,y2,z2));
Console.WriteLine();

//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N
void Kube(int n)
{
    int res = 0;
    for (int i = 1; i <= n; i++)
    {
        res = i*i*i;
        Console.Write($"{res} ");
    }
}
Console.Write("Input a number to see it's kube: ");
int n = Convert.ToInt32(Console.ReadLine());
Kube(n);