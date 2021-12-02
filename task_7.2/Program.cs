using System;

namespace task_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Вас приветствует программа вычисления объема и площади куба по длине ребра.");
                double side = 0;    //длина ребра
                double v, s;    //объем и площадь поверхности куба
                bool mistake = false;   //отрицательное число или не удалось конвертировать в число?
                Console.Write("Введите длину ребра: ");
                try
                {
                    side = Convert.ToDouble(Console.ReadLine());    //считываем длину ребра
                }
                catch
                {
                    mistake = true; //если не удалось конвертировать в число
                    Console.WriteLine("Не удалось прочитать число.");
                }
                if (mistake == false)   //если удалось конвертировать в число
                {
                    SquareCount(side, out v, out s);    //вызываем метод
                    if (side>=0)    //если длина ребра неотрицательная
                    {
                        Console.WriteLine("Объем куба с длиной ребра {0} равен {1}.",side,v);
                        Console.WriteLine("Площадь поверхности куба с длиной ребра {0} равна {1}.", side, s);
                    }
                    else
                    {
                        Console.WriteLine("Длина ребра не может быть отрицательной.");
                    }
                }
                Console.WriteLine();
            }
        }
        static void SquareCount(double side, out double v, out double s) //метод вычисления объема и площади куба по длине ребра
        {
            v = side * side * side;
            s = 6 * side * side;
        }
    }
}
