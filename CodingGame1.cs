using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Lander
{
    public int X { get; set; }
    public int Y { get; set; }
    public int hSpeed { get; set; } // the horizontal speed (in m/s), can be negative.
    public int vSpeed { get; set; } // the vertical speed (in m/s), can be negative.
    public int fuel { get; set; } // the quantity of remaining fuel in liters.
    public int rotate { get; set; } // the rotation angle in degrees (-90 to 90).
    public int power { get; set; } // the thrust power (0 to 4).
}

class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        int surfaceN = int.Parse(Console.ReadLine()); // the number of points used to draw the surface of Mars.
        for (int i = 0; i < surfaceN; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int landX = int.Parse(inputs[0]); // X coordinate of a surface point. (0 to 6999)
            int landY = int.Parse(inputs[1]); // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
        }

        // game loop
        while (true)
        {
            inputs = Console.ReadLine().Split(' ');

            var info = new Lander()
            { 
                X = int.Parse(inputs[0]),
                Y = int.Parse(inputs[1]),
                hSpeed = int.Parse(inputs[2]),
                vSpeed = int.Parse(inputs[3]), // the horizontal speed (in m/s), can be negative.
                fuel = int.Parse(inputs[4]), // the quantity of remaining fuel in liters.
                rotate = int.Parse(inputs[5]), // the rotation angle in degrees (-90 to 90).
                power = int.Parse(inputs[6]) // the rotation angle in degrees (-90 to 90).
            };
            
            // 2 integers: rotate power. rotate is the desired rotation angle (should be 0 for level 1), power is the desired thrust power (0 to 4).
            if (info.Y >= 1000) {
                Console.WriteLine("0 3");
            } else {
                Console.WriteLine("0 4");
            }
        }
    }
}