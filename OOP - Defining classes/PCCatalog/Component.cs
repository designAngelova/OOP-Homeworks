using System;

class Component
{
    private string details;
    private string name;
    private decimal price;

    //      Constructors
    public Component(string name, decimal price, string details = "N/A")
    {
        this.Details = details;
        this.Name = name;
        this.Price = price;
    }

    //      Properties
    public string Details
    {
        get { return details; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Component -> details");
            }

            details = value;
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Component -> name");
            }

            name = value;
        }
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Component -> price");
            }

            price = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Name: {0}, Price: {1}, Details: {2}", this.name, this.price, this.details);
    }
}

