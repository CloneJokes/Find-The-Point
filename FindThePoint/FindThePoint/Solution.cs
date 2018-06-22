﻿using System;
using System.Collections.Generic;
using System.IO;


namespace FindThePoint
{
    class Solution
    {
        public class Coordinates
        {
            //Constructor
            public Coordinates(int x1, int y1, int x2, int y2)
            {
                X1 = x1;
                Y2 = y2;
                X2 = x2;
                Y2 = y2;
            }
            //Getters and Setters
            //prop tab x 2
            public int X1 { get; set; }
            public int Y1 { get; set; }
            public int X2 { get; set; }
            public int Y2 { get; set; }

            //Returns rx, ry
            public string GetSymmetricPoint()
            {
                var x3 = X2 + (X2 - X1);
                var y3 = Y2 + (Y2 - Y1);
                return string.Format("{0} {1}", x3, y3);
            }

        }
        

        static void Main(string[] args)
        {
            //n = number of test cases
            var n = int.Parse(Console.ReadLine());
            //this array list Pair contains coords
            var coords = new List<Coordinates>();
            //for each test case, based on line "x x x x" adds coords into an array
            for (var i = 1; i <= n; i++)
            {
                var line = Console.ReadLine();
                var points = line.Split(' ');
                var x1 = int.Parse(points[0]);
                var y1 = int.Parse(points[1]);
                var x2 = int.Parse(points[2]);
                var y2 = int.Parse(points[3]);
                coords.Add(new Coordinates(x1, y1, x2, y2));
            }
            foreach (var coordinate in coords)
            {
                Console.WriteLine(coordinate.GetSymmetricPoint());// writes each pair collected r's
            }
        }
    }
}
