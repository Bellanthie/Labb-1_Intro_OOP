namespace Labb_1_Intro_OOP
{
    // Created a class called Circle
    class Circle
    {
        //comments here
        // 1) place the constructor within the curly brackets
        // 2) the Constructor is like the builder who knows how to create a new object:
        // It takes in the parameter (radius) and saves it in a 'field variable'
        // **Within the class we also find our METHODS
        public double Radius { get; set; } 
        public Circle(double radius)
        {
            Radius = radius;// the name radius is for the computer to know. "r" is for the user to know so to speak

        }
        public double CalculateArea() // Creating a method where I want the program to calculate the radius
        {
            return Math.PI * Radius * Radius;
        }
    }

    // The main program below that uses the Circle class
    // the MAIN program is the CENTER STAGE where all things happen. 
    // therefore, this is where we 'call upon' the method "CalculateArea()"
    internal class Program
    {
        static void Main(string[] args)
        {
            // One of the circles from the assigment wants us to use a 5 and the other wants us to use 6
            Circle circle1 = new Circle(5);
            Console.WriteLine($"Arean av cirkel 1: {circle1.CalculateArea()}");

            // Calculating second circle using 6
            Circle circle2 = new Circle(6);
            Console.WriteLine($"Arean av cirkel 2: {circle2.CalculateArea()}");


        }
 

    }
}


