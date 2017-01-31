using System;

namespace C_Sharp_Reference.ParameterModifiers
{
    public  class ParameterModifier
    {
     

        //the called method will receive a copy of the original data. As you will notice the data will not change.
        public void ParameterModifierDefault()
        {
            int x = 9, y = 10;
            int myint;

            Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is: {0}", Add(x, y));
            Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
            Console.ReadLine();
        }

        //Out Parameter Modifer. Output parameters do NOT need to be initialized before they are passed to the method. The Method must assign output parameters before exiting.
        //Must be assigned to an appropriate value before exiting the method scope.
        public void ParameterModifierOut()
        {
            int ans;

            int myInt;
            string myString;
            bool myBool;

            FillTheseValues(out myInt, out myString, out myBool);

            Console.WriteLine("*******Start of Multiple Out Parameter Modifier");
            Console.WriteLine("Int is : {0}", myInt);
            Console.WriteLine("String is: {0}", myString);
            Console.WriteLine("Bool is: {0}", myBool);
            Console.WriteLine("*******End of Out Parameter Modifer");

            Add(90, 90, out ans);
            Console.WriteLine("*********Start Of only 1 Out Parameter Modifer");
            Console.WriteLine("90 + 90 = {0}", ans);
            Console.WriteLine("*********Start Of only 1 Out Parameter Modifer");
            Console.ReadLine();

        }

        //Reference parameters must be initialized before they are passed to the method. The reason for this is that you are passing a reference to an existing variable. 
        public void ParameterModifierRef()
        {
            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine("*************Start of the Ref parameter Modifier *****");
            Console.WriteLine("Before: {0}, {1} ", str1, str2);
            SwapStrings(ref str1, ref str2);
            Console.WriteLine("After: {0}, {0}", str1, str2);
            Console.WriteLine("*******End of the REF Parameter Modifier ");
            Console.ReadLine();


        }

        //Note: the value assigned to an optional paramter must be known at compile time, and cannot be resolved at runtime. 
        //Example: DateTime timeStamp = DateTime.Now will throw an error because DateTime.Now is resolved at runtime, not compile time. 
        //Also, optional parameters must always be packed onto the END of a method signature.
        public void OptionalParameters(string message, string owner = "Programmer")
        {

            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of Error: {0}", owner);
            Console.ReadLine();
        }

        private static void SwapStrings(ref string s1, ref string s2)
        {
            string tempString = s1;
            s1 = s2;
            s2 = tempString;
        }

        private void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }

        private static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string";
            c = true;
        }

        private static int Add(int x, int y)
        {
            int ans = x + y;

            x = 1000;
            y = 88888;

            return ans;
        }
    }
}
