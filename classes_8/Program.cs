using System;

namespace classes_8
{
    class Invoice
    {
        public string Article { get; set; }
        public int Quantity { get; set; }
        private int account;
        private string customer;
        private string provider;
        private double price;

        public Invoice(int account, string customer, string provider, int price)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.price = price;
            Article = "";
            Quantity = 0;
        }
        private double PriceWithVAT()
        {
            return price = (price * Quantity) * 1.2;
        }
        private double PriceWithoutVAT()
        {
            return price = price * Quantity;
        }

        public override string ToString()
        {
            return "Account №" + account + "\nCustomer: " + customer + "\nProvider: " + provider + "\nProduct info:\narticle - " + Article
                + ", quantity - " + Quantity + ", price per unit - " + price + "\nTotal price without VAT: " + PriceWithoutVAT().ToString() + ", with VAT: " + PriceWithVAT().ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(123456789, "Владов Владимир", "Иванов Иван", 1250);
            inv.Article = "oak stick";
            inv.Quantity = 5;
            Console.WriteLine(inv.ToString());
            Console.ReadKey();
        }
    }
}
