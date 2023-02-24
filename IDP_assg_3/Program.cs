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

            Element[] elements = new Element[6];
            elements[0] = oxygien;
            elements[1] = iron;
            elements[2] = gold;
            elements[3] = new Element() { name = "Väte", z = 1, type = "Ickemetall", meltingPoint = 13.99, boilingPoint = 20.271 };
            elements[4] = new Element() { name = "Brom", z = 35, type = "Ickemetall", meltingPoint = 265.8, boilingPoint = 332.0 };
            elements[5] = new Element() { name = "Kvicksilver", z = 80, type = "Metall", meltingPoint = 234.3210, boilingPoint = 629.88 };

            //Skriver ut detaljerad information om alla grundämnen
            for (int i = 0; i < elements.Length; i++ )
            {
                elements[i].print();
            }

            //skriver ut namnet på alla metaller
            System.Console.WriteLine("Alla grundämnen som är metaller:");
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].type == "Metall") System.Console.WriteLine("\t"+elements[i].name);
            }

            //skriver ut namnet på alla grundämnen med smältpunkt under 273.16 K och kokpunkt över 273.16 K
            System.Console.WriteLine("\nAlla grundämnen med smältpunkt under 273.16 K och kokpunkt över 273.16 K:");
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].meltingPoint < 273.16 && elements[i].boilingPoint > 273.16)
                    System.Console.WriteLine("\t" + elements[i].name);
            }
        }
    }
}