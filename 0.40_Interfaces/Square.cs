using System;

public class Square : StandardClass
{
	public Square (int lenght):
        base(4, length) { }

    public override double GetArea()
	{
        return SideLength * SideLength;

	}
}
