using System;

public class GraphicsCard
{
    private string memory;
    private string model;

    public GraphicsCard(string memory, string model)
    {
        this.Memory = memory;
        this.Model = model;
    }

    public string Memory
    {
        get { return memory; }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("GraphicsCard -> memory");
            }
            else
            {
                memory = value;
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
                throw new ArgumentNullException("GraphicsCard -> model");
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
                             "  - Memory: {0}\n",
                            this.model, this.memory);
    }
}
