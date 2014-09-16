using System;

public class HardDisk
{
    private string model;
    private int ratesPerMin;

    public HardDisk(string model, int ratesPerMin = 0)
    {
        this.Model = model;
        this.RatesPerMin = ratesPerMin;
    }

    public string Model
    {
        get { return model; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("HardDisk -> model");
            }
            else
            {
                model = value;
            }
        }
    }

    public int RatesPerMin
    {
        get { return ratesPerMin; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("HardDisk -> ratesPerMinute");
            }
            else
            {
                ratesPerMin = value;
            }
        }
    }

    public override string ToString()
    {
        return string.Format("  - Model: {1}\n" +
                             "  - RatesPerMin: {0}\n",
                             this.model,
                             this.ratesPerMin == 0 ? "N/A" : this.ratesPerMin.ToString());
    }
}

