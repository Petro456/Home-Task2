using System;

namespace Home5Task2
{

    class User
    {

        string login { get; set; }
        string name { get; set; }

        string surname { get; set; }

        int age { get; set; }
        


        readonly string data;
       public User (string login, string name, string surname, int age, string data)
        {            
            this.login = login;
            this.name = name;   
            this.surname = surname;
            this.age = age;
            this.data = data;
        }

      public  void Shov()
        {
            Console.WriteLine ($"Логiн користувача   {login}");
            Console.WriteLine ($"iмя користувача   {name}");
            Console.WriteLine($"Прiзвище користувача   {surname}");
            Console.WriteLine($"Вiк користувача   {age}");
            Console.WriteLine($"Дата реєстрацiї користувача   {data}");
        }

    }


    internal class Program
    {
        /*Задание 6

        Используя Visual Studio, создайте проект по шаблону Console Application. Требуется:
        Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст,
        дата заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
        (при создании экземпляра данного класса) без возможности его дальнейшего изменения. Реализуйте вывод на экран
        информации о пользователе.*/


        static void Main(string[] args)
        {
            User user = new User("Rio", "Ivan", "Ivanovuch",30, "25.09.2022");

            user.Shov();
            Console.ReadKey();
        }
    }
}
