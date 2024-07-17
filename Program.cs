namespace Classes_Vs_Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Location a = new Location(20, 40);
            Location b = a; //structs are value type, hence copy of a is equaled to b  whereas classes are reference types
            a.x = 100;
            

            Console.WriteLine(b.x);
        }
    }

    struct Location
    {
        public int x, y;
        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
    }
}
