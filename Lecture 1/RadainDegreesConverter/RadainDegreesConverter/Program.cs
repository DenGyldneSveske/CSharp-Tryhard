namespace RadainDegreesConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter degrees between 0 and 360: ");
            double degrees = Convert.ToDouble(Console.ReadLine());

            while (degrees < 0 || degrees > 360)
            {
                Console.WriteLine("Get it your motherf.....");
                degrees = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"You entered {degrees}");
            Console.WriteLine($"{degrees} is " + DegreesToRadian(degrees) + " radian");



            Console.Write("Please enter value for raidan: ");
            double radian = Convert.ToDouble(Console.ReadLine());

            while (radian < 0 || radian > 2)
            {
                Console.WriteLine("F.ck off");
                radian = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine($"{radian} is " + RadianToDegrees(radian) + " degrees");
        }

        public static double DegreesToRadian(double degreesToConvert)
        {
            double pi = Math.PI;
            return degreesToConvert * (pi/180);
        }

        public static double RadianToDegrees(double radianToConvert)
        {
            double pi = Math.PI;
            return radianToConvert * (180 / pi);
        }
    }
}








/*Skriv to metoder. En der konverterer fra radian til grader, og en, der konverterer 
den anden vej. Vi vælger her, at output fra disse metoder altid ligger imellem 0 
og 359.99+ grader og mellem 0 and 2 × π radian. Vi observerer nemlig, at på en 
cirkel, er 2 π radian er det samme som 0, og 360 grader er det samme som 0 
grader. 
a. radians = degrees * (pi/180) 
b.degrees = radians * (180 / pi) */