using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        // Change to a static method //
        public static int ConvertInputToNumeric(string argTextInput)
        {
            // convert the string to an int //
            return int.Parse(argTextInput);
        }
    }
}
