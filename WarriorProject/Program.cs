
/*
 * A feladat a github-on olvasható!
 */

using System;

namespace WarriorProject
{
    class Program
    {

        class Position
        {
            private int x;
            private int y;

            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }

            public Position(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void MoveVertical(int distance)
            {
                this.x = this.x + distance;
            }

            public void MoveHorizontal(int distance)
            {
                this.y = this.y + distance;
            }

            public void ToConsole()
            {
                Console.WriteLine($"{this.x}, {this.y}");
            }

        }

        class Warrior
        {
            private string name;
            private Position p;

            public Warrior(string name, Position p) 
            {
                this.name = name;
                this.p = p;
            }

            public void ToConsole()
            {
                Console.WriteLine($"{this.name}, position ({this.p.X}, {this.p.Y})");
            }

            public void MoveVertical(int distance)
            {
                p.MoveVertical(distance);
            }

            public void MoveHorizontal(int distance)
            {
                p.MoveHorizontal(distance);
            }

        }
            

        static void Main(string[] args)
        {
                Position position = new Position(2, -1);
                position.ToConsole();
                Warrior warrior = new Warrior("Peter the Iron Man", position);
                warrior.ToConsole();
                warrior.MoveHorizontal(3);
                warrior.MoveVertical(-2);
                warrior.ToConsole();
        }
    }
}
