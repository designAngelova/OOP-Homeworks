using System;
using System.Globalization;
using System.Threading;

class TestLaptop
{
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        Battery myBattery = new Battery(21, "AIO-Ion 2");
        Extras laptopExtras = new Extras(true, false, true, false, true, false, true);
        GraphicsCard myGraphicsCard = new GraphicsCard("2GB DDR2", "ATI RADEON 7770 HD");
        HardDisk myDisk = new HardDisk("1000GB SSHD", 5400);
        Processor myCpu = new Processor(4, 3.2, 4, "Intel Pentium 4-I Super");
        Screen myScreeny = new Screen("1280x680", 15.6, "Glancov");

        Laptop myLenovo = new Laptop(myBattery, myCpu, laptopExtras, myGraphicsCard, myDisk, "Lenovo", "Lenovo 500G", 409.01m, myScreeny);

        //The line below will print 5400 rates for the disk
        Console.WriteLine(myLenovo);
        //we are able to change the characteristics of our laptop because setters are public in the "parts" classes
        myDisk.RatesPerMin = 12000;
        //This will print 12000 rates
        Console.WriteLine(myLenovo);
    }
}

