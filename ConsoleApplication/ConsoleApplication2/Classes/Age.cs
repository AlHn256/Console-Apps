namespace ConsoleApp1
{
    class Age
    {
        readonly string name = "Tom";
        readonly int year;
        public Age(int year)
        {
            this.year = year;
            this.name = "Bill";
        }
        public static void ChangeData()
        {
            //name = "Bill"; // Compile error if uncommented.
            //year = 1967; // Compile error if uncommented.
        }
    }
}
