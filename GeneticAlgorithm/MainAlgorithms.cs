using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public class Globals
    {
        public static Random rand = new Random();
    }

    public class MainAlgorithms
    {
        static int count1, count2;
        static int kun, kc;
        public static int[,] Selection (int[,] population, int[,] matrix, ref int rows, ref int columns, ref int[] best)
        {
            int count = 0;
            int[] select = new int[Form1.r];
            for (int i=0; i<Form1.r; i++) //посчитали длины всех путей в популяции
            {
                select[i] = 0;
                for (int j = 1; j < 10; j++)
                    select[i] += matrix[population[i, j - 1] - 1, population[i, j] - 1];
            }
            for (int i = 0; i < Form1.r; i++) //запомнили лучший путь
            {
                if (select[i] == select.Min())
                {
                    for (int j = 0; j < 10; j++)
                        best[j] = population[i, j];
                    best[10] = select.Min();
                }
            }
            int border = (select.Min() + select.Max()) / 2; //порог
            for (int i = 0; i < Form1.r; i++) //количество отобранных для селекции
                 if (select[i] <= border)
                     count++;
            int[,] unchanged = new int[Form1.r, 10];
            int[,] changed = new int[count,10];
            kun = 0; kc = 0;
            bool fl = true;
            for (int i = 0; i < Form1.r; i++) //деление на 2 матрицы
            {
                if (select[i] == select.Min() && fl)
                {
                    for (int j = 0; j < 10; j++)
                        unchanged[kun, j] = population[i, j];
                    kun++;
                    fl = false;
                }
                if (select[i] <= border)
                {
                    for (int j = 0; j < 10; j++)
                        changed[kc, j] = population[i, j];
                    kc++;
                }
                else
                {
                    for (int j = 0; j < 10; j++)
                        unchanged[kun, j] = population[i, j];
                    kun++;
                }
            }
            int[,] news = Reduction(changed, matrix, ref count);
            for (int i = 0; i < count; i++) //добавление новых в популяцию
            {
                for (int j = 0; j < 10; j++)
                    unchanged[kun+i,j] = news[i, j];
            }
            rows = kun + count;
            columns = 10;
            return unchanged;
        }

        public static int[,] Reduction (int[,] population, int[,] matrix, ref int rows)
        {
            int[,] answer = new int[rows, 10];
            int ka = 0;
            if (rows%2 == 1)
            {
                for (int j = 0; j < 10; j++)
                    answer[ka, j] = population[0, j];
                ka++;
            }
            int br = Globals.rand.Next(2, 8);
            int[] new1 = new int[10];
            int[] new2 = new int[10];
            for (int i=ka; i<rows-1; i+=2)
            {
                new1[0] = population[ka, 0];
                new2[0] = population[ka, 0];
                new1[9] = population[ka, 9];
                new2[9] = population[ka, 9];
                for (int j = 1; j < 9; j++)
                {
                    if (j>=br)
                    {
                        new1[j] = population[i + 1, j];
                        new2[j] = population[i, j];
                    }
                    else
                    {
                        new2[j] = population[i + 1, j];
                        new1[j] = population[i, j];
                    }
                }
                count1 = 0; count2 = 0;
                for (int m = 1; m < 10; m++)
                {
                    count1 += matrix[new1[m - 1] - 1, new1[m] - 1];
                    count2 += matrix[new2[m - 1] - 1, new2[m] - 1];
                }
                if (count1 > count2)
                {
                    for (int j = 0; j < 10; j++)
                        answer[ka, j] = new1[j];
                    ka++;
                }
                else
                {
                    for (int j = 0; j < 10; j++)
                        answer[ka, j] = new1[j];
                    ka++;
                }
            }
            rows = ka;
            return answer;
        }

        public static int[,] Mutation(int[,] population, int rows)//случайное изменение
        {
            int rowToChange, colToChange, newone;
            int[,] answer = new int[Form1.r, 10];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < 10; j++)
                    answer[i, j] = population[i, j];

            for (int i = rows; i < Form1.r; i++)
            {
                rowToChange = Globals.rand.Next(1, rows);
                colToChange = Globals.rand.Next(1, 8);
                newone = Globals.rand.Next(1, 10);
                for (int j = 0; j < 10; j++)
                {
                    answer[i, j] = population[rowToChange - 1, j];
                    answer[i, colToChange] = Globals.rand.Next(1, 10);
                }
            }
            return answer;
        }

        public static int[,] Mutation1(int[,] population, int rows)//замена вершины на соседнюю
        {
            int rowToChange, colToChange, newone;
            int[,] answer = new int[Form1.r, 10];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < 10; j++)
                    answer[i, j] = population[i, j];

            for (int i = rows; i < Form1.r; i++)
            {
                rowToChange = Globals.rand.Next(1, rows);
                colToChange = Globals.rand.Next(1, 8);
                int direction = Globals.rand.Next(1, 2);
                if (direction == 1) newone = population[rowToChange - 1, colToChange]+1;
                else newone = population[rowToChange - 1, colToChange] - 1;
                if (newone == 11) newone = 1;
                if (newone == 0) newone = 10;
                for (int j = 0; j < 10; j++)
                {
                    answer[i, j] = population[rowToChange - 1, j];
                    answer[i, colToChange] = newone;
                }
            }
            return answer;
        } 
    }
}
