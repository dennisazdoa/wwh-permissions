using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Reference.ValueTypesAndReferenceTypes
{
    //Allocated on the Stack, rather than the garbage-collected Heap. Data allocated on the stack can be created and destroyed very quicked, as its lifetime is determined by the defining scope.
    //Heap allocated data,, is monitired by the .NET garbabe collector.
    struct Point
    {
        public int X;
        public int Y;

        public Point(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
        public void Increment()
        {
            X++; Y++;
        }

        public void Decrement()
        {
            X--; Y--;
        }

        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }
}
