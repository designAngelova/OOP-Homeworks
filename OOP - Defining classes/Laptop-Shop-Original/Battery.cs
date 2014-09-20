using System;


public class Battery
{
    private double longevity;
    private string type;

    public Battery(double longevit, string type)
    {
        this.Longevity = longevity;
        this.Type = type;
    }

    public Battery(string type) :this(0, type)
    {
        // Reusing parent constructor
    }

    public double Longevity
    {
        get { return this.longevity; }
        set
        {
            if (longevity < 0)
            {
                throw new ArgumentOutOfRangeException("Longevity");
            }

            this.longevity = value;
        }
    }

    public string Type
    {
        get { return this.type; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Empty battery type");
            }

            this.type = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Longevity: {0}, Type: {1}", this.longevity, this.type);
    }
}

