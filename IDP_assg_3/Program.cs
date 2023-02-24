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

            Element[] elements = new Element[6];
            elements[0] = oxygien;
            elements[1] = iron;
            elements[2] = gold;
            elements[3] = new Element() { name = "Väte", z = 1, type = "Ickemetall", meltingPoint = 13.99, boilingPoint = 20.271 };
            elements[3] = new Element() { name = "Brom", z = 35, type = "Ickemetall", meltingPoint = 265.8, boilingPoint = 332.0 };
            elements[3] = new Element() { name = "Kvicksilver", z = 80, type = "Metall", meltingPoint = 234.3210, boilingPoint = 629.88 };
        }
    }
}