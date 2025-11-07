namespace Workshop2.Workshop2_qn3
{
    internal class VariableType
    {
        public void displayVariable()
        {
            byte Byte = 225;
            short Short = 1000;
            int Int = 50000;
            long Long = 1000000000L;
            float Float = 3.14f;
            double Double = 2.71828;
            decimal Decimal = 123.456m;
            char Char = 'A';
            bool Bool = true;

            int number = 42;
            string numberString = number.ToString();
            string String = "3.14";
            double Doouble = Convert.ToDouble(String);


            Console.WriteLine($"byte: {Byte}");
            Console.WriteLine($"short: {Short}");
            Console.WriteLine($"int: {Int}");
            Console.WriteLine($"long: {Long}");
            Console.WriteLine($"float: {Float}");
            Console.WriteLine($"double: {Double}");
            Console.WriteLine($"decimal: {Decimal}");
            Console.WriteLine($"char: {Char}");
            Console.WriteLine($"bool: {Bool}");

            Console.WriteLine($"Converted to string from int: {number}");
            Console.WriteLine($"Converted to double from string: {Doouble}");
        }
    }
}
