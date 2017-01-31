using System;
using System.Text;

namespace C_Sharp_Reference.StringStuff
{
    public class WorkingWithStrings
    {

        //If using data that changes frequently the the string object is a bad idea. For data that changes frequently use System.Text.Stringbuilder type. For data that does not change 
        //much use the string object.
        public void BasicStringFunctionality()
        {
            //Basic string funtionality
            Console.WriteLine("=> Basic String functionality");
            string firstName = "Dennis";
            Console.WriteLine("Value From firstName: {0}", firstName);

            Console.WriteLine("fistname has {0} characters", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter s?: {0}", firstName.Contains("s"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("is", ""));
            Console.ReadLine();

            Console.WriteLine("=> String Concantenation");

            string lastName = "Tucker";
            string fullName = firstName + lastName;

            Console.WriteLine(fullName);
            Console.ReadLine();

            //Escape characters
            Console.WriteLine("=> Escape characters: \a");
            //**********  \t inserts a horizonatal tab
            string strWithTabs = "Model\t Color\t Speed\t Pet Name ";
            Console.WriteLine(strWithTabs);
            //****** \" inserts a double quote into a string
            Console.WriteLine("My Form of \"Hello World\" ");
            //******** \\inserts a backslash into a string
            Console.WriteLine("C:\\Mydocuments\\mybackslashes\a ");
            //****** \n inserts a new line into a string.
            Console.WriteLine("All finished. \n\n\n]a ");
            Console.ReadLine();


            Console.WriteLine("=> verbatim strings: @");
            //the verbatim string will ignor the backslashes
            Console.WriteLine(@"C:\MyDocuments\IgnoreBackSlashes");
            Console.WriteLine(@"This will ignore the white space");
            Console.ReadLine();

            //A reference type is an object allocated on the garbage=collected managed heap.Even though the string data type is indeed a reference type, the equality operators
            //have been redefined to comapre the VALUES of string objects, not the object in memeory.
            Console.WriteLine("=> String equality:");
            string equality1 = "Hello!";
            string equality2 = "Yo!";
            Console.WriteLine("equality1 = {0}", equality1);
            Console.WriteLine("equality2 = {0}", equality2);
            Console.WriteLine();
            Console.WriteLine("equality1 == equaltiy2: {0}", equality1 == equality2);
            Console.WriteLine("equality1 == Hello!: {0}", equality1 == "Hello!");
            Console.WriteLine("equality1 == HELLO!: {0}", equality1 == "HELLO!");
            Console.WriteLine("equality1 == hello!: {0}", equality1 == "hello!");
            Console.WriteLine("equality1.Equals(equality2): {0}", equality1.Equals(equality2));
            Console.WriteLine("Yo.Equals(equality2): {0}", "Yo!".Equals(equality2));
            Console.WriteLine();
            Console.ReadLine();

            //System.String are immutable. One you assign a string a object with its inital value, the character data cannot be changed. 
            //What you are actually doing doing any time you modify that string value (uppercase, lowercase, concat, etc) you are actually returning a brand
            //new string object in a modified format.
            Console.WriteLine("=> immutable strings. Or string values that cannot be changes");
            string immutable1 = "This is my string.";
            Console.WriteLine("immutable1 = {0}", immutable1);

            //uppercase immutable1
            string upperString = immutable1.ToUpper();
            Console.WriteLine("upperstring = {0}", upperString);

            //no!!! immutble1 is the same format!
            Console.WriteLine("immutable1 = {0}", immutable1);
            Console.ReadLine();
        }

        public string StringConcat(string firstString, string secondString)
        {

            return string.Empty;
        }

        public void ReverseAString()
        {
            string input = "Dennis Tucker";
            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {

            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
