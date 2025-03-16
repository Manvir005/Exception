using System;


public class InvalidRadiusException : Exception
{
    
    public InvalidRadiusException() : base("Radius is greater than zero.")
    {
    }

    
    public InvalidRadiusException(double radius) : base($"Radius {radius} is not valid. Radius must be greater than zero.")
    {
    }
}