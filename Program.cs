using System;

namespace Lab02_LogicalExpression_ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            CsharpOperators cs = new CsharpOperators();
            cs.OperatorMethod();
            cs.TestingNotEqual();
            cs.BreakingOutOfLoops();
            cs.TestSelection();
            cs.TestCasting();
            int result = cs.TestBoxing(5); //value 5 is Boxed into Int32 object
            Int32 int32 = new Int32();
            int32 = 89; //value 89 is boxed as well here
            int result2 = cs.TestBoxing(int32); // no boxing as the method expects an object

            double result3 = cs.TestBoxing(3.412);
            Double myDouble = new Double();
            myDouble = 9.876;
            double result4 = cs.TestBoxing(myDouble);

            //works with object class
            Object one_twenty = 120;
            int number_one_twenty = (int)one_twenty;
        }
    }
    class CsharpOperators
    {
        #region Operators
        public void OperatorMethod()
        {
            //+, -, /, *, % these work as in mathematics
            //Unary operators example increment operator ++ --
            int count = 0;
            count = 1;
            count = 2;
            count = count + 1; // to explain non technical: on the left side we store and on the right we process(or evaluate)
            count = 2 + 1; //the value of 3 will be stored in count
            count++; //same way as above but shorter
            ++count; //also can be done this way
            count--; //decrement
                     //There is something call operator precedence
            int result = (24 + 4 / 2) - (12 * 3); // BODMAS applies
            Console.WriteLine(result);
            //
            int y = ++count;  //is increased and then saved in y
            int k = count++; //it is saved in k before is increased (if you want to store the same value in k)
            //you can increment by more steps instead of single stepping
            int z = count + 10;
            int a = 0;
            a += 10; // increment a in steps of 10
            for (int i = 0; i < 1000; i++)
            {

                Console.WriteLine(i += 10);
            }
            //Bitwise operators|, &, ^
            // And, & operator
            //printing truth table
            Console.WriteLine(true & true);
            Console.WriteLine(false & true);
            Console.WriteLine(true & false);
            Console.WriteLine(false & false);
            // Or, | operator
            //printing truth table
            Console.WriteLine(true | true);
            Console.WriteLine(false | true);
            Console.WriteLine(true | false);
            Console.WriteLine(false | false);
            // Exclusive, ^ operator
            //printing truth table
            Console.WriteLine(true ^ true);
            Console.WriteLine(false ^ true);
            Console.WriteLine(true ^ false);
            Console.WriteLine(false ^ false);

            // && and || are called logical operator
            bool result2 = (false) && (TestLogicalExpression());
            bool result3 = (false) & (TestLogicalExpression());
            //using the ||
            bool result4 = (false) || (TestLogicalExpression());
            bool result5 = (false) | (TestLogicalExpression());

        }
        #endregion

        #region Logical_Expression
        public bool TestLogicalExpression()
        {
            return true; //Test & and |
        }
        bool answer = "Markson" == "markson"; // comparing two strings
        bool answer2 = true == true; // compare boolean
        bool answer3 = (new Object()) == (new Object()); //hack solution // their memory location is different 
        bool result4 = 'A' == 'a';
        // Not equal != or negator operator
        bool answer5 = (new Object()) != (new Object()); //not equal because they are pointing to the same memory location  //returns true 
        public void TestingNotEqual()
        {
            int x = 10;
            if (!(x == 11)) // if I don't know the value I flip the expression like this
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        public void TestObjectEquality()
        {
            Object obj1 = new Object();
            Object obj2 = obj1;
            bool result = obj1 == obj2;
        }
        // < > >= <= relatinal operators
        //if the operands are binary it will do binary opereations
        bool result6 = 5 < 7; // less than
        bool result7 = 5 <= 7; // less than or equal
        bool result8 = 5 > 7; //greater than
        bool result9 = 5 <= 7; //greter than or equal
        #endregion

        #region Conditional_Statements
        //Breaking out of loops
        public void BreakingOutOfLoops()
        {
            for (int r = 0; r < 10; r++)
            {
                if (r == 5)
                {
                    break; // break is like return without a value
                }
                Console.WriteLine("the value of r is: {0}", r); // string interpolation
                Console.WriteLine("the value of r is: " + r);     // same as above
            }
            Console.WriteLine("Return here after break");

            for (int r = 0; r < 10; r++)
            {
                if (r == 5 | r == 9)
                {
                    continue; // break is like return without a value
                }
                Console.WriteLine("the value of r is: {0}", r); // string interpolation
                Console.WriteLine("the value of r is: " + r);     // same as above
            }
        }
        //Selections
        public void TestSelection()
        {
            if (true) // if statement
            {
                Console.WriteLine("for only one evaluation");
            }
            if (true) // if for alternate conditions
            {

            }
            else
            {

            }

            //switch statements
            Console.WriteLine("Please enter a:");
            int z = Convert.ToChar(Console.Read());
            switch (z)
            {
                case 1:
                    Console.WriteLine(z);
                    break;
                case 2:
                    Console.WriteLine(z);
                    break;
                case 3:
                    Console.WriteLine(z);
                    break;
                case 50:
                    Console.WriteLine(z);
                    break;
                case 5:
                    Console.WriteLine(z);
                    break;
                default:
                    Console.WriteLine("What did yoiu type?");
                    Console.WriteLine(z);
                    break;
            }
        }
        //Casting (or switching types)
        public void TestCasting()
        {
            //Implicite Casting
            int counter = 19;
            double score = counter;
            double score2 = 14.99999;
            //Explicit casting
            int counter2 = (int)score2;   //explicitly casting to int
        }
        public int TestBoxing(Int32 value)   // this is an object of Int32 class
        {
            return value;  //unboxing Int32 object to int
        }
        public double TestBoxing(Double value)   // Unboxing Double object to double        //method overload
        {
            return value;
        }
        #endregion
    }
}
