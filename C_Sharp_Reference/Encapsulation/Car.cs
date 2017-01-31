using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Reference.Encapsulation
{
    //The term "object" is used to describe an instance of a given class type created using the new keyword.
    public class Car
    {
        public string petName;
        public int CurrentSpeed;


        public Car()
        {
            petName = "Chuck";
            CurrentSpeed = 10;
        }
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", petName, CurrentSpeed);
        }

        public void SpeedUp(int delta)
        {
            CurrentSpeed += delta;
        }

        public void PublicEncapsulationExample()
        {
            Console.WriteLine("********Public Encapsulation Example");

            Car myCar = new Car();

            myCar.petName = "Dennis";
            myCar.CurrentSpeed = 10;

            //Speed up the car a few times
            for (int i = 0; i < 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.ReadLine();
        }
    }
}
