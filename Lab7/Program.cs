using System;

namespace Lab7
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Лабораторна робота №4 на тему: <КЛАСИ ТА МЕТОДИ>");
            Console.WriteLine("");
            Console.WriteLine("Варiант №3");
            Console.WriteLine("");
            Console.WriteLine("Виконав:Харченко Максим Олександрович");
            Console.WriteLine("");
            Console.WriteLine("Група: ЕС-137Бстн");
            Console.WriteLine("");
            static int[,] EneterArray(int[,] a,int size)
            {

                Console.WriteLine("Enter values for array : ");
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j <size; j++)
                    {
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine(" ");
                }
                return a;
            }
            static int[]EnterArray(int[]a,int size)
            {
                Console.WriteLine("Enter values for array : ");
                for (int i = 0; i < size;i++) 
                    a[i] = Convert.ToInt32(Console.ReadLine());

                return a;
            }
            static  int[,] MultiplicationA(int[,] a, int[,] b)
            {
                int[,] r = new int[4, 3];
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        r[i, j] = 0;
                        for (int k = 0; k < 3; k++)
                        {
                         
                            r[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
                return r;
            }
            static int[] MultiplicationB(int[] a, int[] b)
            {
                int[] f = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    if (i != 3)
                    {
                        f[i] = b[i] * a[i];
                    }
                    else {
                        f[i] = b[i]*0;
                        break;
                   
                    }
                }
                return f;
            }
            static void Average(int[] a,int size)
            {
                int temp = 0;
                for(int i = 0; i < size; i++)
                {
                    temp += a[i];
                }
                Console.WriteLine("Average of vector values is: " + temp/size);
            }
            int[,] A = new int[4, 4];
            int[,] B = new int[3, 3];
            int[] C = new int[3];
            int[] D = new int[4];
            int[,] R = new int[4,4];
            int[] F = new int[4];
                int size = 0;
                size = A.Length;
                size = Convert.ToInt32(Math.Sqrt(A.Length));
                A = EneterArray(A,size);
                size = Convert.ToInt32(Math.Sqrt(B.Length));
                B = EneterArray(B,size);
                 R = MultiplicationA(A, B);
                 for (int i = 0; i < 4; i++)
                 {
                     for (int j = 0; j <3; j++)
                     {
                         Console.Write("{0}\t", R[i, j]);
                     }
                     Console.WriteLine(" ");
               }
  
            C = EnterArray(C,C.Length);
            D = EnterArray(D,D.Length);
            F = MultiplicationB(C, D);
            Console.WriteLine(" ");
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(F[i]);
            }
            Average(F, F.Length);

        }
    }
}
