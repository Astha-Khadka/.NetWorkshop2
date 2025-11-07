namespace Workshop2.Workshop2_qn2
{
    internal class Circle
    {
        public const double PI = 3.14;
        public static double CalculateArea(double radius)
        {
            return PI * radius * radius;
        }
        public static double CalculatePerimeter(double radius)
        {
            return 2 * PI * radius;
        }
        public void displayAns()
        {
            Console.WriteLine("PI value: " + PI);

            double radius = 5.0;
            double area = CalculateArea(radius);
            double perimeter = CalculatePerimeter(radius);

            Console.WriteLine($"Circle with radius {radius}:");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");


        }
    }
}
