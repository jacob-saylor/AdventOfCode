using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Day3
{
    public static class WireCalculation
    {
        public static int DetermineManhattanDistance(string firstWire, string secondWire)
        {
            var firstWireCommands = firstWire.Split(',').ToList();
            var secondWireCommands = secondWire.Split(',').ToList();

            var firstWireVectors = BuildVectorList(firstWireCommands);
            var secondWireVectors = BuildVectorList(secondWireCommands);

            // Determine where the points are equal (Overlapping wires)    
            var intersections = firstWireVectors.Intersect(secondWireVectors).ToList();

            return 0;
        }

        private static List<LocationVector> BuildVectorList(List<string> commandVectors)
        {
            var vectorList = new List<LocationVector>();
            var currentLocation = new LocationVector { X = 0, Y = 0 };
            vectorList.Add(currentLocation);

            foreach (var item in commandVectors)
            {
                var command = DetermineCommand(item[0]);
                var updatedLocation = CalculateLocation(currentLocation, item, command);

                vectorList.AddRange(FillInLocations(currentLocation, updatedLocation, command));
                vectorList.Add(updatedLocation);
                currentLocation = updatedLocation;
            }

            return vectorList;
        }

        private static List<LocationVector> FillInLocations(LocationVector startingVector, LocationVector targetVector, Command command)
        {
            // ToDo : Screwed up the logic here as far as "drawing the line". Need to rework
            var vectors = new List<LocationVector>();
            if (command == Command.Right)
            {
                var distance = targetVector.X - startingVector.X;
                for (int i = startingVector.X + 1; i < distance; i++)
                {
                    vectors.Add(new LocationVector { X = i, Y = startingVector.Y });
                }
            }

            if (command == Command.Left)
            {
                var distance = startingVector.X - targetVector.X;
                for (int i = startingVector.X - 1; i > distance; i--)
                {
                    vectors.Add(new LocationVector { X = i, Y = startingVector.Y });
                }
            }

            if (command == Command.Up)
            {
                var distance = targetVector.Y - startingVector.Y;
                for (int i = startingVector.Y + 1; i < distance; i++)
                {
                    vectors.Add(new LocationVector { X = startingVector.X, Y = i });
                }
            }

            if (command == Command.Down)
            {
                var distance = startingVector.Y - targetVector.Y;
                for (int i = targetVector.Y - 1; i > distance; i--)
                {
                    vectors.Add(new LocationVector { X = startingVector.X, Y = i });
                }
            }

            return vectors;
        }

        private static int DetermineDistance(LocationVector firstVector, LocationVector secondVector)
        {
            return Math.Abs(secondVector.X - firstVector.X) + Math.Abs(secondVector.Y - firstVector.Y);
        }

        private static LocationVector CalculateLocation(LocationVector location, string commandVector, Command command)
        {            
            var action = commandVector.Substring(1, commandVector.Length - 1);

            return command switch
            {
                Command.Right => new LocationVector { X = location.X + Int32.Parse(action), Y = location.Y },
                Command.Left => new LocationVector { X = location.X - Int32.Parse(action), Y = location.Y },
                Command.Up => new LocationVector { X = location.X, Y = location.Y + Int32.Parse(action) },
                Command.Down => new LocationVector { X = location.X, Y = location.Y - Int32.Parse(action) },
                _ => throw new NotSupportedException()
            };
        }

        private static Command DetermineCommand(char command)
        {
            return command switch
            {
                'R' => Command.Right,
                'L' => Command.Left,
                'U' => Command.Up,
                'D' => Command.Down,
                _ => throw new NotSupportedException()
            };
        }
    }

    public enum Command
    {
        Left,
        Right,
        Up,
        Down
    }

    public struct LocationVector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            var vector = (LocationVector)obj;
            return X == vector.X && Y == vector.Y;
        }

        public static bool operator ==(LocationVector left, LocationVector right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(LocationVector left, LocationVector right)
        {
            return !(left == right);
        }
    }
}
