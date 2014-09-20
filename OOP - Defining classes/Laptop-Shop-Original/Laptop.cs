using System;
using System.ComponentModel;

public class Laptop
{
    private Battery battery;
    private string graphicsCard;
    private string hdd;
    private string manifacturer;
    private string model;
    private decimal price;
    private string processor;
    private string ram;
    private string screen;

    public Laptop(string model,
        decimal price,
        Battery battery = null,
        string graphicsCard = "N/A",
        string hdd = "N/A",
        string manifacturer = "N/A",
        string ram = "N/A",
        string screen = "N/A",
        string processor = "N/A")
    {
        this.Battery = battery;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Manifacturer = manifacturer;
        this.Model = model;
        this.Price = price;
        this.Ram = ram;
        this.Screen = screen;
        this.Processor = processor;
    }

    public Laptop(string model,
        decimal price,
        Battery battery,
        string graphicsCard,
        string hdd,
        string manifacturer,
        string ram,
        string screen)
        : this(model, price, battery, graphicsCard, hdd, manifacturer, ram, screen, "N/A")
    {
        // Reusing parent constructor
    }

    public Laptop(string model,
        decimal price,
        string graphics,
        string hdd,
        string ram)
        : this(model, price, null, graphics, hdd, "N/A", ram, "N/A")
    {
        // Reusing parent constructor
    }

    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.Price = price;
    }

    public Battery Battery
    {
        get { return this.battery; }
        private set { this.battery = value; }
    }

    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Empty Graphics Card Value");
            }

            this.graphicsCard = value;
        }
    }

    public string Hdd
    {
        get { return this.hdd; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Empty HDD Value");
            }

            this.hdd = value;
        }
    }

    public string Manifacturer
    {
        get { return this.manifacturer; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Empty Manifacturer Value");
            }

            this.manifacturer = value;
        }
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Empty Model Value");
            }

            this.model = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid Price Value");
            }

            this.price = value;
        }
    }

    public string Processor
    {
        get { return this.processor; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Empty Processor Value");
            }

            this.processor = value;
        }
    }

    public string Ram
    {
        get { return this.ram; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Empty RAM Value");
            }

            this.ram = value;
        }
    }

    public string Screen
    {
        get { return this.screen; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Empty Screen Value");
            }

            this.screen = value;
        }
    }
    // ToString override ommited - only implemented in Battery class, please see the code below

    public static void Main()
    {
        Laptop myLappy = new Laptop("Lenovo G500", 600, new Battery(4.0, "Varta"), "NVidia GForce 440MX", "Maxtor 500GB",
                                    "Lenovo", "Pravetz 1100 2GB DDR2");

        Laptop hisLappy = new Laptop("Lenovo G600", 1200, "ATI Radeon 9999 HD", "Maxtor 8 TB", "1 TB DDR6");

        Laptop herLappy = new Laptop("Dachia 5656G", 1222.12m);

        Laptop theirLappy = new Laptop("Lenovo G500", 600, new Battery(4.0, "Varta"), "NVidia GForce 440MX", "Maxtor 500GB",
                                "Lenovo", "Pravetz 1100 2GB DDR2", "14.5 1680x720");


        foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(myLappy))
        {
            string name = descriptor.Name;
            object value = descriptor.GetValue(myLappy);

            if ((value != null) && (value != "N/A"))
            {
                Console.WriteLine("{0}: {1}", name, value);  
            }
        }
    }
}

