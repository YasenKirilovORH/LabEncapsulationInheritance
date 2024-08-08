using System;
using System.Text;

namespace BoxData;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box (double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;

    }

    public double Length
    {
        get => length;
        private set
        {
            if(value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            this.length = value;
        }
    }

    public double Width
    {
        get => width;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            this.width = value;
        }
    }

    public double Height
    {
        get => height;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            this.height = value;
        }
    }

    public double SurfaceArea()
    {
        double area = 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;

        return area;
    }

    public double Volume()
    {
        double volume = Length * Width * Height;
        return volume;
    }

    public override string ToString()
    {
        string output = $"Surface Area – {SurfaceArea():F2}{Environment.NewLine}" +
                        $"Volume - {Volume():F2}";

        return output;
    }
}
