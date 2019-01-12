namespace CodeTests.Library
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            string output = "";

            if (input % 3 == 0) output += "Fizz";
            if (input % 5 == 0) output += "Buzz";
            if (output == "") output = input.ToString();

            return output;
        }
    }
}
