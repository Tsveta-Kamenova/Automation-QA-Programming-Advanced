using System;
using System.Text;

namespace BoxData;

public class Box
{
    private double _length;
    private double _width;
    private double _height;

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double Length
    {
        get { return this._length; }
        private set 
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Length cannot be zero or negative.");
            }
            this._length = value; 
        }
    }

    public double Width
    { 
        get { return this._width; } 
        private set
        {
            if(value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            this._width = value;
        }
    }
    public double Height
    {
        get { return this._height; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            this._height = value;
        }
    }

    public double SurfaceArea()
    {
        double area = 2 * (this.Length * this.Height + this.Width * this.Height + this.Length * this.Width);
        return area;
    }

    public double Volume()
    {
        double volume = this.Height * this.Length * this.Width;
        return volume;
    }

    public override string ToString()
    {
        return $"Surface Area – {this.SurfaceArea():f2}{Environment.NewLine}Volume – {this.Volume():f2}";
    }

}
