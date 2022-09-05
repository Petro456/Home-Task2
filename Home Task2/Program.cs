using System;

namespace Home_Task2
{

    class Converter
    {
        double USD { get; }  
        double EUR { get; }
        double Zloty { get; }


        public Converter(double usd, double eur, double zloty)
        {
            USD = usd;
            EUR = eur;
            Zloty = zloty;
        }


        public double ConvertInUSD (double value)
        {
            return value / USD;
        }
        public double ConvertOutUSD(double value)
        {
            return value * USD;
        }

        public double ConvertInEUR(double value)
        {
            return value / EUR;
        }
        public double ConvertOutEUR(double value)
        {
            return value * EUR;
        }

        public double ConvertInZloty(double value)
        {
            return value * Zloty;
        }
        public double ConvertOutZloty(double value)
        {
            return value * Zloty;
        }

    }
    internal class Program
    {
        /*Задание 2 

            Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: Создать класс Converter.
        В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, и инициализирует поля соответствующие курсу
        3-х основных валют, по отношению к гривне – public Converter(double usd, double eur, double rub). Написать программу, которая будет выполнять 
        конвертацию из гривны в одну из указанных валют, также программа должна производить конвертацию из указанных валют в гривну. */


        static void Main(string[] args)
        {
            var converter = new Converter(40.05, 42.05, 8.5);

            Console.WriteLine("Як Ви бажаєте зробити обмiн валют, виберiть один iз варiантiв:");
            Console.WriteLine("1: Купити iншу валюту");
            Console.WriteLine("2: Здiйснити обмiн на гривнi");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    ConvertIn (converter);
                    break;
                case 2:
                    ConvertOut (converter);
                    break;
            }

            Console.WriteLine("Дякуємо, що скористались нашими послугами)");
            Console.ReadKey();

             static void ConvertIn(Converter converter)
            {
                Console.WriteLine("Зробiть свiй вибiр:");
                Console.WriteLine("1: Перевести у USD");
                Console.WriteLine("2: Перевести у EUR");
                Console.WriteLine("3: Перевести у Zloty");

                var variant = int.Parse(Console.ReadLine());

                Console.WriteLine("Ведiть суму");

                var suma = double.Parse(Console.ReadLine());

                switch (variant)
                {
                    case 1:
                        Console.WriteLine(converter.ConvertInUSD(suma));
                        break;
                    case 2:
                        Console.WriteLine(converter.ConvertInEUR(suma));
                        break;
                    case 3:
                        Console.WriteLine(converter.ConvertInZloty(suma));
                        break;
                }
             }

                 static void ConvertOut (Converter converter)
                {
                    Console.WriteLine("Зробiть свiй вибiр:");
                    Console.WriteLine("1: Перевести з USD в гривнi");
                    Console.WriteLine("2: Перевести з EUR в гривнi");
                    Console.WriteLine("3: Перевести з Zloty в гривнi");

                    var variant = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ведiть суму");

                    var suma = double.Parse(Console.ReadLine());

                    switch (variant)
                    {
                        case 1:
                            Console.WriteLine(converter.ConvertOutUSD(suma));
                            break;
                        case 2:
                            Console.WriteLine(converter.ConvertOutEUR(suma));
                            break;
                        case 3:
                            Console.WriteLine(converter.ConvertOutZloty(suma));
                            break;
                    }
                 }










        }
    }
}
