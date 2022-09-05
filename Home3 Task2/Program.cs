using System;

namespace Home3_Task2


{
    class Invoice
    {
        
        readonly int account;
        readonly string customer;
        readonly string provider;

      public  Invoice(int account, string customer, string provider)
        {
           this.account= account;
           this.customer= customer;
           this.provider= provider;
        }

       private string article { get; set; }
       private int quantity { get; set; }

       public Invoice(int account, string customer, string provider, string article, int quantity):this( account, customer, provider)
        {
            this.article = article;
            this.quantity = quantity;
            
        }
        public double RozrachynokNds(double nds = 0.22)
        {
            return account + (account * nds);
        }

        public void Show()
        {
            Console.WriteLine($" {customer} замовив на  {provider}  {quantity} {article}  та виставив рахунок," +
                $"\n який буде становити {account} грн. без НДС, а {RozrachynokNds()} грн. iз НДС");
        }

    }

    internal class Program
    {

        /*Задание 4 

            Используя Visual Studio, создайте проект по шаблону Console Application.
            Требуется: Создать класс Invoice. В теле класса создать три поля int account, string customer, 
        string provider, которые должны быть проинициализированы один раз (при создании экземпляра данного класса)
        без возможности их дальнейшего изменения. В теле класса создать два закрытых поля string article, int quantity 
        Создать метод расчета стоимости заказа с НДС и без НДС. Написать программу, которая выводит на экран сумму оплаты
        заказанного товара с НДС или без НДС.*/

        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(2000, "Товари", "загрузку", "Машин", 10);
            

            invoice.RozrachynokNds();
            invoice.Show();

            Console.ReadKey();

        }
    }
}
