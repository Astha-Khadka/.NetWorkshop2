namespace Workshop2.Workshop2_qn5
{
    internal class DateTimes
    {
        public void displayDatetime()
        {
            DateTime birthDate = new DateTime(2005, 04, 26);
            DateTime currentDate = DateTime.Now;
            TimeSpan ageTimeSpan = currentDate - birthDate;
            int ageInYears = (int)(ageTimeSpan.Days / 365.25);

            DateTime birthDatePlus = birthDate.AddDays(10);

            Console.WriteLine($"My birthdate: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Current date: {currentDate.ToShortDateString()}");
            Console.WriteLine($"My age: {ageInYears} years");
            Console.WriteLine($"Birthdate + 10 days: {birthDatePlus.ToShortDateString()}");
        }
    }
}
