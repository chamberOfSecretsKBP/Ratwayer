using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите n");
        int n = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите m");
        int m = Int32.Parse(Console.ReadLine());

        Matrix a = new Matrix(n, m);

        a.FillMatrix();
        a.ShowMatrix();

        
        
        
   Console.ReadKey();

    }
}