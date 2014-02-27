namespace RangeExceptionMain
{
    using System;
    class RangeExceptionMain
    {
        static void Main()
        {
            int start = 1;
            int end = 100;
            EnterNumber(start, end);

            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);
            EnterDateTime(startDate, endDate);
        }

        private static void EnterNumber(int start, int end)
        {
            Console.WriteLine("Enter an integer number in the range [{0}...{1}].", start, end);
            try
            {
                Console.WriteLine("Your number: {0}", GetNumber(start, end));
            }
            catch (InvalidRangeException<int> re)
            {
                Console.WriteLine("Entered value must be in the range [{0}...{1}]", re.Start, re.End);
            }
            catch (Exception)
            {
                Console.WriteLine("Another exception");
            }
        }
        public static int GetNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>("Number is not in the range.", start, end);
            }
            return number;
        }

        private static void EnterDateTime(DateTime startDate, DateTime endDate)
        {
            Console.WriteLine("Enter date in the range [1.1.1980...31.12.2013]");
            try
            {
                Console.WriteLine("Your date is: {0}", GetDate(startDate, endDate));
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("Date is not in the range [{0}...{1}]", ex.Start, ex.End);
            }
        }

        public static DateTime GetDate(DateTime start, DateTime end)
        {
            DateTime date = DateTime.Parse(Console.ReadLine());

            if (date < start || date > end)
            {
                throw new InvalidRangeException<DateTime>("Entered date is not in the range [{0}...{1}]", start, end);
            }
            return date;
        }
    }
}
