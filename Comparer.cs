using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Comparer
    {
        public double FirstValue { get; private set; }

        public double SecondValue { get; private set; }

        public string Result { get; private set; }

        public Comparer ()
        {
            FirstValue = 0;
            SecondValue = 0;
            Result = string.Empty;
        }

        public string GetValues ()
        {
            try
            {
                Console.WriteLine("Че смотришь? Вводи это чертого число: ");
                FirstValue = Convert.ToDouble (Console.ReadLine());

                Console.WriteLine("Теперь второе число: ");
                SecondValue = Convert.ToDouble (Console.ReadLine());

                return "Молодец, хоть здесь справился, долбоеб";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "Число нужно ввести, мудак, ЧИСЛО";
            }
        }

        public string CompareValues()
        {
            Console.WriteLine(GetValues());
            if (FirstValue > SecondValue)
            {
                return "Первое число больше";
            }
            else if (FirstValue < SecondValue)
            {
                return "Второе число больше";
            }
            else
            {
                return "Числа равны";
            }
        }

    }
}
