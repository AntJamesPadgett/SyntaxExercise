namespace SyntaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //var answer = 4;  //explcit typing--
            //string response;

            //if (answer <12)
            // {
            //    response = answer + " is less than nine";

            // else
            // {
            //    response = answer + " greater than or equal to nine";
            // }
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

            System.Console.WriteLine(response);
        }
    }

}

