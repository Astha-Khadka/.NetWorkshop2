using Workshop2.Workshop2_Q4;
using Workshop2.Workshop2_qn1;
using Workshop2.Workshop2_qn2;
using Workshop2.Workshop2_qn3;
using Workshop2.Workshop2_qn5;

namespace Workshop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //For Qn 1
           LuckyNumber luckyNumber = new LuckyNumber();
           luckyNumber.userDisplay();

            //For Qn 2
            Circle circle = new Circle();
            circle.displayAns();
            // You cannot change the value of PI because it is declared as a constant. A constant(const) always keeps the same value once it is set.
            //That’s why the compiler shows an error saying you can’t assign a new value to it.


            //For Qn 3
            VariableType variable = new VariableType();
            variable.displayVariable();

            //For Qn 4
            Arrays arr = new Arrays();
            arr.displayArray();

            //For Qn 5
            DateTimes datetimes = new DateTimes();
            datetimes.displayDatetime();

        }

    }
}
