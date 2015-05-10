using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpaceObject
{
    public string name { get; set; }
    public double x { get; set; }
    public double y { get; set; }

}
class ToTheStars
{
    static int numberOfStarSystems = 3;

    static void Main(string[] args)
    {
        //declarations
        List<SpaceObject> systems = new List<SpaceObject>();
        SpaceObject system = new SpaceObject();
        string input;
        double coor1;
        double coor2;

        //star systems initialization
        for (int i = 0; i < numberOfStarSystems; i++)
        {
            input = Console.ReadLine();
            string name = input.Split()[0].ToLower();
            coor1 = double.Parse(input.Split()[1]);
            coor2 = double.Parse(input.Split()[2]);
            system = new SpaceObject { name = name, x = coor1, y = coor2 };
            systems.Add(system);
        }
        //normandy initialization
        input = Console.ReadLine();
        coor1 = double.Parse(input.Split()[0]);
        coor2 = double.Parse(input.Split()[1]);
        SpaceObject normandy = new SpaceObject { name = "Normandy", x = coor1, y = coor2 };

        //fly awayyyyy
        Move(normandy, systems);

    }
    
    static string GetPlace(List<SpaceObject> systems, SpaceObject normandy)
    {
        foreach (var system in systems)
        {
            if (normandy.x >= system.x - 1 && normandy.x <= system.x + 1 &&
                normandy.y >= system.y - 1 && normandy.y <= system.y + 1)
            {
                return system.name;
            }
        }
        return "space";
    }

    static void Move(SpaceObject normandy, List<SpaceObject> systems)
    {
        int moves = int.Parse(Console.ReadLine());
        for (int i = 0; i <= moves; i++)
        {
            string place = GetPlace(systems, normandy);
            Print(place);
            normandy.y = normandy.y + 1;
        }
    }

    static void Print(string place)
    {
        Console.WriteLine(place);
    }
}

