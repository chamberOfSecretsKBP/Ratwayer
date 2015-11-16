using System;
using System.Security.Cryptography;

class Matrix
{
    private int[,] matrix;
    private int n;
    private int m;

    public Matrix(int n, int m)
    {
        if (n < 1)
        {
            this.n = 2;
        }
        if (m < 1)
        {
            this.m = 2;
        }
        this.n = n;
        this.m = m;

        matrix = new int[this.n, this.m];
    }

    public void FillMatrix()
    {
        int x;
        int shift = 0;
        int currentPosition = 0;
        Random rand = new Random();

        x = (n > m) ? m - 1 : n - 1;

       
        while (x > 0 )
        { 
            for (int side = 0; side < 4; side++)
            {

                if (currentPosition == (n * m) )
                        return;
                

                for (int j = shift; j < ((n < m) ? m : n); j++)
                {
                    if ((side == 0) && (j<m-shift))
                    {
                        matrix[shift, j] = rand.Next(1, 10);
                        currentPosition++;

                        ShowMatrix();
                        Console.ReadLine();
                    }

                    if ((side == 1) && (j!=shift) && (j<n-shift))
                    {
                        matrix[j, m-shift-1] = rand.Next(1, 10);
                        currentPosition++;

                        ShowMatrix();
                        Console.ReadLine();
                    }

                    if ((side == 2) && (j != shift) && (j < m - shift))
                    {
                        matrix[n - shift-1, ((m-1) - j)] = rand.Next(1, 10);
                        currentPosition++;

                        ShowMatrix();
                        Console.ReadLine();
                    }

                    if ((side == 3) && (j != shift) && (j < n - 1) && (j < n - shift-1))
                    {
                        matrix[((n - 1) - j), shift] = rand.Next(1,10);
                        currentPosition++;

                        ShowMatrix();
                        Console.ReadLine();
                    }
                }
            }
            x--;
            shift+=1;
        }
    }


    public void ShowMatrix()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0} ",matrix[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}



