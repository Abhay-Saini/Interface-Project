using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Project
{

    abstract class Shapes
    {
        public abstract int Area();
    }
    class Square : Shapes
    {
        private int sides;

        public Square(int x = 0)
        {
            sides = x;
        }

        public override int Area()
        {
            Console.WriteLine("The area of square is");
            return sides * sides;
        }   
    }
    class Rectangle : Shapes
    {
        public int length;
        public int width;

        public Rectangle(int a, int b)
        {
            length = a;
            width = b;
        }
        public override int Area()
        {
            Console.WriteLine("The area of rectangle is :");
            return length * width;
        }
    }
   

    class Program
    {
        static void Main(string[] args)
        {
            Shapes obj = new Square(5);
            int result = obj.Area();
            Console.WriteLine(result);


            Shapes obj2 = new Rectangle(4,3);
            int result2 = obj2.Area();
            Console.WriteLine(result2);
            Console.ReadLine();





        }
    }

   
}
