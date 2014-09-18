using System;

public class Battery
{
    private double longevity;
    private string model;

    public Battery(double longevity, string model)
    {
        this.Longevity = longevity;
        this.Model = model;
    }

    public Battery(string model) : this(0.0d, model)
    {
        Model = model;
    }

    public double Longevity
    {
        get { return longevity; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Battery -> longevity");
            }
            else
            {
                longevity = value;
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
                throw new ArgumentNullException("Battery -> model");
            }
            else
            {
                model = value;
            }
        }
    }

    public override string ToString()
    {
        return string.Format("  - Model: {1}\n" +
                             "  - Longevity: {0}\n",
                             this.model,
                             this.longevity == 0.0d ? "N/A" : this.longevity.ToString());
    }
}
