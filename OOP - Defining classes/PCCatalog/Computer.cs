using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class Computer
{
    private string name;
    private Component processor;
    private Component graphics;
    private Component hdd;
    private Component motherboard;
    private decimal price;

    public Computer(string name, Component processor, Component graphics, Component hdd, Component motherboard)
    {
        this.Name = name;
        this.Price = CalculatePrice(processor.Price, graphics.Price, hdd.Price, motherboard.Price);
        this.processor = processor;
        this.graphics = graphics;
        this.hdd = hdd;
        this.motherboard = motherboard;
    }

    public Computer(string name, Component processor, Component hdd)
    {
        this.Name = name;
        this.Price = CalculatePrice(processor.Price, hdd.Price);
        this.processor = processor;
        this.hdd = hdd;
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Computer -> name");
            }

            name = value;
        }
    }

    public decimal Price
    {
        get { return price; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Component -> price");
            }
            price = value;
        }
    }

    private static decimal CalculatePrice(decimal cpu, decimal hdd, decimal graphics = 0,
        decimal mBoard = 0)
    {
        return cpu + hdd + graphics + mBoard;
    }

    public override string ToString()
    {
        return string.Format("  - Name: {0}\n" +
                             "  - Price: {1:C}\n" +
                             "  - Motherboard: {2}\n" +
                             "  - Hdd: {3}\n" +
                             "  - Graphics: {4}\n" +
                             "  - Processor: {5}\n",
                             name, price,
                             motherboard == null ? "N/A" : motherboard.ToString(),
                             hdd,
                             graphics == null ? "N/A" : graphics.ToString(),
                             processor == null ? "N/A" : processor.ToString());
    }
}


public class TestComputerCatalog
{
    //testing purposes 
    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");
        List<Computer> allComputers = new List<Computer>();

        Component cpu = new Component("AMD Athlon 1.7+", 120, "1.66 GHz 2 MB Cache");
        Component hard = new Component("Maxtor 500TB", 299);
        Component gCard = new Component("ATI Radeon 7770 HD", 300, "power");
        Component mBoard = new Component("Gigabyte", 199);

        Computer myPc = new Computer("Custom XRPower", cpu, gCard, hard, mBoard);
        allComputers.Add(myPc);
        Computer hisPC = new Computer("VeryBad XX3", cpu, hard);
        allComputers.Add(hisPC);
        Computer ourComp = new Computer("Slavery 11A", new Component("Intel Inside :)", 129.11m),
                                                       new Component("ATI Meedeon 1292HD", 288, "Can play CS"),
                                                       new Component("Seagate 6TB", 300, "fast"),
                                                       new Component("Gigabity 69 GB Serial-bus", 138));
        allComputers.Add(ourComp);

        Comparison<Computer> comparator = (a, b) => a.Price.CompareTo(b.Price);
        allComputers.Sort(comparator);

        foreach (var comp in allComputers)
        {
            Console.WriteLine(comp);
        }
    }
}

  // Sample output
  // -------------
  //- Name: VeryBad XX3
  //- Price: 419,00 лв.
  //- Motherboard: N/A
  //- Hdd: Name: Maxtor 500TB, Price: 299, Details: N/A
  //- Graphics: N/A
  //- Processor: Name: AMD Athlon 1.7+, Price: 120, Details: 1.66 GHz 2 MB Cache

  //- Name: Slavery 11A
  //- Price: 855,11 лв.
  //- Motherboard: Name: Gigabity 69 GB Serial-bus, Price: 138, Details: N/A
  //- Hdd: Name: Seagate 6TB, Price: 300, Details: fast
  //- Graphics: Name: ATI Meedeon 1292HD, Price: 288, Details: Can play CS
  //- Processor: Name: Intel Inside :), Price: 129,11, Details: N/A

  //- Name: Custom XRPower
  //- Price: 918,00 лв.
  //- Motherboard: Name: Gigabyte, Price: 199, Details: N/A
  //- Hdd: Name: Maxtor 500TB, Price: 299, Details: N/A
  //- Graphics: Name: ATI Radeon 7770 HD, Price: 300, Details: power
  //- Processor: Name: AMD Athlon 1.7+, Price: 120, Details: 1.66 GHz 2 MB Cache