namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int subtract = a - b;
            int multiply = a * b;

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} and the remainder is {remainder}");

            Console.WriteLine("Enter the radius of your circle.");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));

            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k);  //output is 16
        }
        public static double AreaOfCircle(double radius)
        {
            var area= Math.PI * Math.Pow(radius, 2);
            return area;
            


        }
    }
}
