namespace PCCatalog
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;

    public class TestComputer
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Computer myComputer = new Computer("Shtaiga 23XR");

            myComputer.AddComponent(new Component("Intel i5", 127.00m, "2.4 GHz 4 MB cache"));
            myComputer.AddComponent(new Component("Maxtor", 222.10m, "500 GB"));
            myComputer.AddComponent(new Component("ATI Radeon 9990", 327.00m, "2GB, crossfire, shader 5.0"));
            myComputer.AddComponent(new Component("Seagate", 97.20m, "4 GB DDR2"));
            myComputer.AddComponent(new Component("Gigabyte 2", 427.00m));

            Computer hisComputer = new Computer("Axort 111");

            hisComputer.AddComponent(new Component("AMD Athlon", 123.00m, "1.4 GHz 1 MB cache"));
            hisComputer.AddComponent(new Component("Maxtor", 122.10m, "50 GB"));
            hisComputer.AddComponent(new Component("Nvidia GForce 4", 127.00m, "1GB"));
            hisComputer.AddComponent(new Component("Atkinson", 17.20m, "512 MB, DDR2"));
            hisComputer.AddComponent(new Component("Gigabyte 1", 127.00m));

            Computer thierComputer = new Computer("Qekd 001");

            thierComputer.AddComponent(new Component("AMD Senetron 2", 223.00m, "3.4 GHz 1 MB cache"));
            thierComputer.AddComponent(new Component("Maxtor III", 322.10m, "150 TB"));
            thierComputer.AddComponent(new Component("Nvidia GForce 8", 327.00m, "8GB"));
            thierComputer.AddComponent(new Component("Oenna", 127.20m, "8 GB, DDR4"));
            thierComputer.AddComponent(new Component("ASUS 8", 727.00m));

            List<Computer> computers = new List<Computer>()
            {
                myComputer,
                hisComputer,
                thierComputer
            };

            computers.Sort((a, b) => a.Price < b.Price ? -1 : a.Price > b.Price ? 1 : 0);

            foreach (var comp in computers)
            {
                Console.WriteLine(comp);
            }
        }
    }
}
