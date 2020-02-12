namespace Market_Store
{
    using System;

    public class Program
    {
        public static void Main()
        {
            ICard bronzeCard = new BronzeCard(0);
            ICard silverCard = new SilverCard(600);
            ICard goldCard = new GoldCard(1500);

            string bronzeCardResult = PayDesk.CalulateDiscount(150, bronzeCard);
            string silverCardResult = PayDesk.CalulateDiscount(850, silverCard);
            string goldCardResult = PayDesk.CalulateDiscount(1300, goldCard);

            Console.WriteLine(bronzeCardResult);
            Console.WriteLine();
            Console.WriteLine(silverCardResult);
            Console.WriteLine();
            Console.WriteLine(goldCardResult);
        }
    }
}
