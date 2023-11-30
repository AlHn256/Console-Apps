namespace ConsoleApp1
{
    class Age2
    {
        //public static const double KOEF = 4.5; // const cannot be static
        public const double KOEF = 4.5; // const cannot be static

        readonly int year;
        public Age2(int year)
        {
            this.year = year;
        }
        public void ChangeYear()
        {
            //this.year = 1967; // Compile error if uncommented.
        }
    }
}
