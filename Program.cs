using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b6_mass
{
    class Program
    {
        static void Main(string[] args)
        {
            //B6_1();
            //B6_2();
            //B6_3();
            //B6_5();
            B6_6();
            Console.ReadLine();
        }

        public static void B6_1()
        {
            int[] mas1 = new int[6];
            Console.WriteLine("Enter numbers for mas1");
            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = Convert.ToInt32(Console.ReadLine());


            }

            for (int i = 0; i < mas1.Length; i++)
            {

                Console.Write($" {mas1[i]}");

            }

        }

        public static void B6_2()
        {
            int[,] mas2 = new int[3,3]
            {
                {9,4,7},{3,6,3},{2,1,5}
            };
            int rows = mas2.GetUpperBound(0)+1;
            int columns = mas2.Length/rows;
            Console.WriteLine(rows);
            Console.WriteLine(columns);

            Console.WriteLine("Сам массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < mas2.Length / rows; j++)
                {
                    Console.Write(" "+mas2[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < rows; i++)
            {
                
                int maxValue = 0;
               
                for (int j = 0; j < columns-1; j++)
                {
                    if ((mas2[j,i] > mas2[j + 1, i]) && (mas2[j, i] > maxValue))
                    {
                        
                        maxValue = mas2[j, i];
                    }
                    else
                    {
                        
                    }
                }
               
                Console.WriteLine("Max in row"+(i+1)+" = " + maxValue);
            }

            
            /*if (mas2[0, 0] < mas2[0, 1] & mas2[0, 0] < mas2[0, 2])
            {
                if (mas2[0, 1] < mas2[0, 2] & mas2[0,1] < mas2[0, 0])
                {
                    if (mas2[0, 2] < mas2[0, 0] & mas2[0, 1] < mas2[0, 0])
                    {

                    }

                }
                else
                {
                    Console.WriteLine(mas2[0, 1]);
                }
            }

            else
            {
                Console.WriteLine(mas2[0, 0]);
            }*/



        }

       

        public static void B6_3()
        {
            
            int[] mas = new int[5];
            Console.WriteLine("Enter ten numbers for mas");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());


            }
            Console.WriteLine("ваш массив до сортировки");
            for (int i = 0; i < mas.Length; i++)
            {

                Console.Write($" {mas[i]}");

            }

            int value = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        value = mas[i];
                        mas[i] = mas[j];
                        mas[j] = value;
                    }
                }
            }
          
                    Console.WriteLine("ваш массив после сортировки");
                for (int i = 0; i < mas.Length; i++)
                {

                    Console.Write($" {mas[i]}");

                }

        }

        public static void B6_5()
        {
            Console.WriteLine("Введите строку");
            string str = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ваша строка до обреза: "+ str);

            Console.WriteLine("длина строки " + str.Length);

            if (str.Length > 13)
            {
                str= str.Remove(13).Insert(13, "...");
                
                Console.WriteLine("Ваша строка обрезана " + str);
                
            }

            else
            {
                Console.WriteLine("Ваша строка" + str);
            }
        }

        public static void B6_6()
        {
            Console.WriteLine("Введите стишок");
            string str = Convert.ToString(Console.ReadLine());
            str = str.Replace("о", "а");
            str = str.Replace("л", "ль");
            str = str.Replace("ть", "т");
            //Console.WriteLine("Ваша стих в строку " + str);
            string[] words = str.Split(new char[] { ';' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            
            /*if (str.Contains(";"))
            {
                str = str.Remove(13).Insert(13, "...");

                Console.WriteLine("Ваша строка обрезана " + str);

            }

            else
            {
                Console.WriteLine(str);
            }*/
        }
    }
}

 