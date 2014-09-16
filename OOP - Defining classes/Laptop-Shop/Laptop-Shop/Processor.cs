using System;


public class Processor
{
    private double cache;
    private double clockRate;
    private int cores;
    private string model;


    public Processor(double cache, double clockRate, int cores, string model)
    {
        this.Cache = cache;
        this.ClockRate = clockRate;
        this.Cores = cores;
        this.Model = model;
    }

    public Processor(double clockRate, int cores, string model)
        : this(0.0d, clockRate, cores, model)
    {
        //reusing constructor   
    }

    public double Cache
    {
        get { return cache; }
        set
        {
            if (cache < 0)
            {
                throw new ArgumentOutOfRangeException("Processor -> cache");
            }
            else
            {
                cache = value;
            }
        }
    }

    public double ClockRate
    {
        get { return clockRate; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Processor -> clockRate");
            }
            else
            {
                clockRate = value;
            }
        }
    }

    public int Cores
    {
        get { return cores; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Processor -> cores");
            }
            else
            {
                cores = value;
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
                throw new ArgumentNullException("Processor -> model");
            }
            else
            {
                model = value;
            }
        }
    }

    public override string ToString()
    {
        return string.Format("  - Model: {0}\n" +
                             "  - Cores: {1}\n" +
                             "  - ClockRate: {2}\n" +
                             "  - Cache: {3}\n",
                             this.model, this.cores, this.clockRate,
                             this.cache == 0 ? "N/A" : this.cache.ToString());
    }
}
