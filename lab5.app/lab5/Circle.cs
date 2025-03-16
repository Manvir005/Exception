public class Circle
{
    public double Radius { get; private set; }


    public void SetRadius(double radius)
    {
        
        if (radius > 0)
        {
            this.Radius = radius;
        }
        else
        {
            throw new InvalidRadiusException(radius);
        }
    }

    public override string ToString()
    {
        return $"Circle with radius: {Radius}";
    }
}