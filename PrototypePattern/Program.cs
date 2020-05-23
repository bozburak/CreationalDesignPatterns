using PrototypePattern.Models;
using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager();
            colorManager["red"] = new Color(255, 0, 0);
            colorManager["green"] = new Color(0, 255, 0);
            colorManager["blue"] = new Color(0, 0, 255);

            Color color1 = colorManager["red"].Clone() as Color;
            Color color2 = colorManager["green"].Clone() as Color;
            Color color3 = colorManager["blue"].Clone() as Color;            Console.ReadKey();        }
    }
}
