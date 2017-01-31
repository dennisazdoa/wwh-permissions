using System;

namespace C_Sharp_Reference.Encapsulation
{

    public class Motorcycle
    {
        public int DriverIntensity;
        public string Name;

        public void SetDriverName(string name)
        {
            Name = name;
        }
        public void PopWheely()
        {
            for (int i = 0; i <= DriverIntensity; i++)
            {
                Console.WriteLine("Yeeee Haaaeww!");
                Console.ReadLine();
            }
        }

        //ctor is a snippet that can be used
        public Motorcycle()
        {

        }

        public Motorcycle(int intensity)
        {
            DriverIntensity = intensity;
        }
    }
}
