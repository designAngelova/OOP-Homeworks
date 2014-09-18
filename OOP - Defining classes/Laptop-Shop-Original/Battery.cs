using System;


public class Battery
{
    private double longevity;
    private string type;

    //      Constructors
    public Battery(double longevit, string type)
    {
        this.Longevity = longevity;
        this.Type = type;
    }

    public Battery(string type) :this(0, type)
    {
        
    }

    //      Properties
    public double Longevity
    {
        get { return longevity; }
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
        get { return type; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Empty battery type");
            }

            this.type = value;
        }
    }

    //      Formatting methods
    public override string ToString()
    {
        return string.Format("Longevity: {0}, Type: {1}", this.longevity, this.type);
    }
}

