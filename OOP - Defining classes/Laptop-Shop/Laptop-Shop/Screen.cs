using System;

public class Screen
{
    private string resolution;
    private double size; // assuming measurement in inches
    private string type;

    public Screen(string resolution, double size, string type = "N/A")
    {
        this.Resolution = resolution;
        this.Size = size;
        this.Type = type;
    }

    public string Type
    {
        get { return type; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Screen -> type");
            }
            else
            {
                type = value;
            }
        }
    }

    public double Size
    {
        get { return size; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Screen->size");
            }
            else
            {
                size = value;
            }
            
        }
    }

    public string Resolution
    {
        get { return resolution; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Screen -> resolution");
            }
            else
            {
                resolution = value;
            }
        }
    }

    public override string ToString()
    {
        return string.Format("  - Size: {1}\n" +
                             "  - Type: {0}\n" +
                             "  - Resolution: {2}\n",
                             this.type, this.size, this.resolution);
    }
}
