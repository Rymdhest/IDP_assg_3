namespace IDP_assg_3
{
    internal class Program
    {
        class Element
        {
            public string name;
            public int z;
            public string type;
            public double meltingPoint;
            public double boilingPoint;

            public void print()
            {
                System.Console.WriteLine($"Grundämne: {name}({z})");
                System.Console.WriteLine($"\tTyp: {type}");
                System.Console.WriteLine($"\tSmältpunkt: {meltingPoint} K");
                System.Console.WriteLine($"\tKokpunkt: {boilingPoint} K\n");
            }
        }
        static void Main(string[] args)
        {
            Element oxygien = new Element() { name = "Syre", z = 8, type = "Ickemetall", meltingPoint = 54.36, boilingPoint = 90.188};
            Element iron = new Element() { name = "Järn", z = 26, type = "Metall", meltingPoint = 1811, boilingPoint = 3134 };
            Element gold = new Element() { name = "Guld", z = 79, type = "Metall", meltingPoint = 1337.33, boilingPoint = 3243 };

            oxygien.print();
            iron.print();
            gold.print();
        }
    }
}