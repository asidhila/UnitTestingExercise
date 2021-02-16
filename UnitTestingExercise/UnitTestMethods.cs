using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        //DONE - Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference



        //DONE- Create an Add method that passes 3 integers
        public int Add(int one, int two, int three)
        {
            return one + two + three;
        }

        //DONE - Create a Subtract method that passes 2 integers
        public int Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }

        // DONE - Create a Multiply method that passes 2 integers
        public int Multiply(int one, int two)
        {
            throw new NotImplementedException();
        }
        //Done -  Create a Divide method that passes 2 integers
        public int Divide(int one, int two)
        {
            throw new NotImplementedException();
        }
        // Create 2 methods that will utilize the [Fact] tests you wrote
        public char ReturnH()
        {
            return 'h';
        }

    }

}

        
    


