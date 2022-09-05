using System;

namespace Home2Task
{

    class Employee
    {
        string name { get; set; }
        string surname { get; set; }       

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;       
        }

        string posada { get; set; }
        int stag { get; set; }


        public void Worker(int stag)
        {
            int salary;
            double podatok;

            if (stag > 1 && stag < 3)
            {
                salary = 10000;
                podatok = salary * 0.25;
            }
            else if (7 > stag && stag > 3)
            {
                salary = 15000;
                podatok = salary * 0.25;
            }
            else if (50 > stag && stag > 7)
            {
                salary = 20000;
                podatok = salary * 0.25;
            }
            else
            {
                salary = 30000;
                podatok = salary * 0.25;
            }
            Console.WriteLine($"Зарплата працiвника {salary} грн ");
            Console.WriteLine($"Податок iз зарплати  {podatok}");
        }
        public void Manager(int stag)
        {
            int salary;
            double podatok;

            if (stag > 1 && stag < 3)
            {
                salary = 15000;
                podatok = salary * 0.25;
            }
            else if ( 7 > stag && stag > 3)
            {
                salary = 20000;
                podatok = salary * 0.25;
            }
            else if ( 50 > stag && stag > 7)
            {
                salary = 25000;
                podatok = salary * 0.25;
            }
            else
            {
                salary = 30000;
                podatok = salary * 0.25;
            }
            Console.WriteLine($"Зарплата працiвника {salary} грн ");
            Console.WriteLine($"Податок iз зарплати  {podatok}");
        }
        public void Director(int stag)
        {
            int salary;
            double podatok;

            if (stag > 1 && stag < 3)
            {
                salary = 20000;
                podatok = salary * 0.25;
            }
            else if (7 > stag && stag > 3)
            {
                salary = 25000;
                podatok = salary * 0.25;
            }
            else if (50 > stag && stag > 7)
            {
                salary = 30000;
                podatok = salary * 0.25;
            }
            else
            {
                salary = 35000;
                podatok = salary * 0.25;
            }

            Console.WriteLine($"Зарплата працiвника {salary} грн ");
            Console.WriteLine($"Податок iз зарплати  {podatok}");
        }

        public void RozrachunokPrachivnyka(string posada, int stag)
        {
            this.posada = posada;
            this.stag = stag;

            if (posada == "worker")
            {
                Console.WriteLine($"Iмя працiвника {name} ");
                Console.WriteLine($"Прiзвище  {surname}");
                Console.WriteLine($"Посада  {posada}");
                Console.WriteLine($"Стаж роботи  {stag} ");


                Worker(stag);                               
            }
            if (posada == "manager")
            {
                Console.WriteLine($"Iмя працiвника {name} ");
                Console.WriteLine($"Прiзвище  {surname}");
                Console.WriteLine($"Посада  {posada}");
                Console.WriteLine($"Стаж роботи  {stag} ");
                Manager(stag);                              
            }
            if (posada == "director")
            {
                Console.WriteLine($"Iмя працiвника {name} ");
                Console.WriteLine($"Прiзвище  {surname}");
                Console.WriteLine($"Посада  {posada}");
                Console.WriteLine($"Стаж роботи  {stag} ");
                Director(stag);
                              
            }
            else
            {
                Console.WriteLine("Ви ввели неправильнi данi");
            }
        }
        //public void Shov()
        //{

        //    Console.WriteLine($"iмя працiвника {name}  Прiзвище  {surname}  Посада  {posada}  стаж роботи {stag} ");

        //    Console.WriteLine($"Зарплата працiвника {salary} i  Податок iз зарплати  {podatok} ");

        //}

    }


    internal class Program
    {
        /*Задание 3 

            Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: Создать класс Employee. 
        В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля,
        соответствующие фамилии и имени сотрудника. Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа)
        ''и налоговый сбор. Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад и налоговый сбор.*/

        static void Main(string[] args)
        {
            Employee employee = new Employee ("Ivan","Ivanovich");

            employee.RozrachunokPrachivnyka("director", 20);

           
            // employee.Shov();

            Console.ReadKey();
        }
    }
}
