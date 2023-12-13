using System;

class Program
{
    static void Main()
    {
        int[,] matran = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int X = matran.GetLength(0);
        int Y = matran.GetLength(1);

        int maxElement = matran[0, 0]; 
        int maxX = 0;
        int maxY = 0;

       
        for (int i = 0; i < X; i++)
        {
            for (int j = 0; j < Y; j++)
            {
                if (matran[i, j] > maxElement)
                {
                    maxElement = matran[i, j];
                    maxX = i;
                    maxY = j;
                }
            }
        }

        
        Console.WriteLine("Phần tử lớn nhất của ma trận là: " + maxElement);
        Console.WriteLine("Tọa độ của phần tử lớn nhất: ({0}, {1})", maxX, maxY);

      

        Console.Write("Nhập số hàng của ma trận: ");
        int InputX = int.Parse(Console.ReadLine());

        Console.Write("Nhập số cột của ma trận: ");
        int InputY = int.Parse(Console.ReadLine());

        int[,] matrans = new int[InputX, InputY];

        
        for (int i = 0; i < InputX; i++)
        {
            for (int j = 0; j < InputY; j++)
            {
                Console.Write($"Nhập giá trị cho phần tử ({i}, {j}): ");
                matrans[i, j] = int.Parse(Console.ReadLine());
            }
        }

        
        Console.WriteLine("Ma trận nhập từ người dùng:");
        for (int i = 0; i < InputX; i++)
        {
            for (int j = 0; j < InputX; j++)
            {
                Console.Write(matrans[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}