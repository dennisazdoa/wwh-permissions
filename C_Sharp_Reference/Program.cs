using C_Sharp_Reference.Encapsulation;
using C_Sharp_Reference.ParameterModifiers;
using C_Sharp_Reference.StatticDataAndMembers;
using C_Sharp_Reference.StringStuff;
using System;
using System.Collections.Generic;

namespace C_Sharp_Reference
{
    class Program
    {
        static void Main(string[] args)
        {


            //Parameter Modifier Example.
            //ParameterModifierExample();

            // WorkingWithStringsExample();
            //PublicEncapsulationExample();
            StaticDataAndMembers();
        
        }

        public static void StaticDataAndMembers()
        {
            Console.WriteLine("**** Func With Static Data ******* \n");
            SavingsAccount s1 = new SavingsAccount(50);
            //Print the current interest rate.
            Console.WriteLine("Interest rate is : {0}", SavingsAccount.GetInterestRate());
            //Try changing the current interest rate;
            SavingsAccount.SetInterestRate(0.08);
           
            SavingsAccount s2 = new SavingsAccount(100);
            //The variable is reset each time you create a new "SavingsAccount" object.
            Console.WriteLine("Interest rate is: {0}", SavingsAccount.GetInterestRate());
            SavingsAccount s3 = new SavingsAccount(10000.75);

            Console.ReadLine();
        }

        public static void PublicEncapsulationExample()
        {
            //Car myCar = new Car();
            //myCar.petName = "Fred";
            //myCar.PublicEncapsulationExample();

            Motorcycle moto = new Motorcycle(10);
            moto.PopWheely();

        }

        private static void WorkingWithStringsExample()
        {
            WorkingWithStrings workingWithString = new WorkingWithStrings();

            workingWithString.BasicStringFunctionality();
        }

        private static void ParameterModifierExample()
        {
            ParameterModifier parameterModifier = new ParameterModifier();

            //Parameter Modifier Example. Using the default parameter modifer as by value. 
            parameterModifier.ParameterModifierOut();
            parameterModifier.ParameterModifierDefault();
            parameterModifier.ParameterModifierRef();
            parameterModifier.OptionalParameters("This is my message");
            parameterModifier.OptionalParameters("Optional parameter", "CFO");
        }



    }
}
