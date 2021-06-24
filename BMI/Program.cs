using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, weight, bmi;

            Console.WriteLine("***Консольная утилита для вычислении Индекса Массы Тела***");
           
            Console.WriteLine("Введите свой рост в сантиметрах");
            if (Double.TryParse(Console.ReadLine(), out height) && height > 50 && height < 260)
            {
                height /= 100.0;
            }
            else
            { 
                Console.WriteLine("Некорректный ввод данных!" +
                    "\nВведены буквы или введеный рост слишком маленький(большой)!" +
                    "\nДля завершения работы нажмите любую клавишу...");
                Console.ReadKey();
                return;
            }
            
            Console.WriteLine("Введите свой вес в килограммах");
            if (!(Double.TryParse(Console.ReadLine(), out weight) && weight > 30 && weight < 300))
            {
                Console.WriteLine("Некорректный ввод данных!" +
                    "\nВведены буквы или введеный вес слишком маленький(большой)!" +
                    "\nДля завершения работы нажмите любую клавишу...");
                Console.ReadKey();
                return;
            }

            bmi = Math.Round(weight / Math.Pow(height, 2), 1);
  
            if (bmi < 18.5)
            { Console.WriteLine("ИМТ = {0} - Ниже нормального", bmi); }
            else if (bmi >= 18.5 && bmi < 25)
            { Console.WriteLine("ИМТ = {0} - Нормальный", bmi); }
            else
                Console.WriteLine("ИМТ = {0} - Выше нормального", bmi);

            Console.WriteLine("Для завершения работы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
