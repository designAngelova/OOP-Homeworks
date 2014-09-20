using System;

class Component
{
    private string details;
    private string name;
    private decimal price;

    public Component(string name, decimal price, string details = "N/A")
    {
        this.Details = details;
        this.Name = name;
        this.Price = price;
    }

    public string Details
    {
        get { return this.details; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Component -> details");
            }

            this.details = value;
        }
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Component -> name");
            }

            this.name = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Component -> price");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Name: {0}, Price: {1}, Details: {2}", this.name, this.price, this.details);
    }
}

