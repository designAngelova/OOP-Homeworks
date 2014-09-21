namespace LaptopShop
{
    using System;

    public class LaptopTester
    {
        public static void Main()
        {
            Laptop myLaptop = new Laptop("G500", new Battery("Varta"));
            Laptop hisLaptop = new Laptop("G600", 1222.00m);

            Console.WriteLine(hisLaptop);
        }
    }
}
