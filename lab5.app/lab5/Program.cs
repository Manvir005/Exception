public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            
            Circle circle1 = new Circle();
            circle1.SetRadius(5.0);
            Console.WriteLine(circle1.ToString());
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
  
            Circle circle2 = new Circle();
            circle2.SetRadius(-3.0);
            Console.WriteLine(circle2.ToString());
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
    
            Circle circle3 = new Circle();
            circle3.SetRadius(0.0);
            Console.WriteLine(circle3.ToString());
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}