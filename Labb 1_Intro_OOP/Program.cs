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

        public 


    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
 

    }
}


