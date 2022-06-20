using System;

namespace Proj3
{

    class Flower : IEquatable<Flower>
    {
        public Flower()
        {
            Console.WriteLine("The flower grows.");
        }

        protected string colour;
        public string Colour { get => colour;  set => colour = value; }

        public void Bloom() { Console.WriteLine("It blooms!"); }
        public void Wither() { Console.WriteLine("It withers..."); }

        public bool Equals(Flower other)
        {
            return other != null && GetType() == other.GetType() && colour == other.colour;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Flower);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(colour);
        }
        public override string ToString() 
        { 
            Console.WriteLine("It's {0}.", colour); return colour; 
        }
    }

    class Petal : Flower
    {
        public Petal()
        {
            Console.WriteLine("There is a petal.");
        }
    }

    class Bud : Petal
    {
        public Bud()
        {
            Console.WriteLine("There is a bud.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Bud tulip = new();

            tulip.Colour = "red";

            tulip.Bloom();
            tulip.ToString();
            tulip.Wither();
        }
    }
}
