using System;

public class StandardRegularPolygon
{
    public int NumberOfSides { get; set; }
    public int SideLength { get; set; }

    public StandardRegularPolygon (int side, int lenght)
	{
        NumberOfSides = sides;
        SideLength = lenght;
	}

    public double GetPerimeter()
    {
        return NumberOfSides * SideLength;
    }

    public virtual double GetArea()
    {
        throw new NotImplementedException();
    }
}
