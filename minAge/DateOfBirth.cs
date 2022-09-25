namespace minAge
{
    public struct DateOfBirth
    {
        public int Day;
        public int Month;
        public int Year;

        static public DateOfBirth MaxBirth = new DateOfBirth(99, 99, 9999);
        static public DateOfBirth MinBirth = new DateOfBirth(0, 0, 0);

        public DateOfBirth(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }


        //Возвращаю 1 если man1 старше man2, -1 если man 1 младше man2, 0 если man1 и man2 родились в один день
        public static int CompareDate(DateOfBirth man1, DateOfBirth man2)
        {
            if (man1.Day == man2.Day && man1.Month == man2.Month && man1.Year == man2.Year)
                return 0;
            else if ((man1.Year < man2.Year) || (man1.Year == man2.Year && man1.Month < man2.Month) || (man1.Year == man2.Year && man1.Month == man2.Month && man1.Day < man2.Day))
                return 1;
            else
                return -1;
        }

        public string ToString()
        {
            return $"{Day}.{Month}.{Year}";
        }
    }
}