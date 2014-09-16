using System;

public class Laptop
{
    private Battery battery;
    private Processor cpu;
    private Extras extras;
    private GraphicsCard graphicsCard;
    private HardDisk hardDrive;
    private string manifacturer;
    private string model;
    private decimal price;
    private Screen screen;

    // create a laptop from individual parts / "intuitive" method
    public Laptop(Battery battery, Processor cpu, Extras extras, GraphicsCard graphics, HardDisk hdrive,
        string manifacturer, string model, decimal price, Screen screen)
    {
        this.Battery = battery;
        this.Cpu = cpu;
        this.Extras = extras;
        this.GraphicsCard = graphics;
        this.HardDrive = hdrive;
        this.Manifacturer = manifacturer;
        this.Model = model;
        this.Price = price;
        this.Screen = screen;
    }

    public Laptop(Battery battery, Processor cpu, Extras extras, GraphicsCard graphics, HardDisk hdrive,
        string manifacturer, string model, Screen screen)
        : this(battery, cpu, extras, graphics, hdrive, manifacturer, model, 0.0m, screen)

    {
        //reusing constructor
    }

    public Battery Battery
    {
        get { return battery; }
        private set { battery = value; }
    }

    public Processor Cpu
    {
        get { return cpu; }
        private set { cpu = value; }
    }

    public Extras Extras
    {
        get { return extras; }
        private set { extras = value; }
    }

    public GraphicsCard GraphicsCard
    {
        get { return graphicsCard; }
        private set { graphicsCard = value; }
    }

    public string Manifacturer
    {
        get { return manifacturer; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("HardDisk -> manifacturer");
            }
            else
            {
                manifacturer = value;
            }
        }
    }

    public string Model
    {
        get { return model; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Laptop -> model");
            }
            else
            {
                model = value;
            }
        }
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Laptop -> price");
            }
            else
            {
                price = value;
            }
        }
    }

    public Screen Screen
    {
        get { return screen; }
        private set { screen = value; }
    }

    public HardDisk HardDrive
    {
        get { return hardDrive; }
        private set { hardDrive = value; }
    }

    public override string ToString()
    {
        return string.Format("Model: {0}\n" +
                             "Manifacturer: {1}\n\n" +
                             "Graphics Card: \n{2}\n" +
                             "Hard Drive: \n{3}\n" +
                             "CPU: \n{4}\n\n" +
                             "Battery: \n{5}\n\n" +
                             "Screen: \n{6}\n\n" +
                             "Price: {7}\n" +
                             "Extras: \n{8}",
                             this.model, this.manifacturer, this.graphicsCard, this.hardDrive, this.cpu, this.battery,
                             this.screen,
                             this.price == 0.0m ? "N/A" : this.price.ToString(),
                             this.extras);
    }
}
