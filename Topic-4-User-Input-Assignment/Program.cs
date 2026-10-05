namespace Topic_4_User_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
            Part2();
        }
        //Console.WriteLine("Assignment by Easton Powers");
        //Console.WriteLine("User inputs name, age and salary");
        public static void Part1()
        {
            string username;
            int age;
            double wage;
            Console.Write("I am Program.cs. What is your name? (PLEASE INPUT NAME): ");
            username = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();

            Console.Write("What's up, " + username);
            Console.WriteLine("?");
            Console.WriteLine();
            Console.WriteLine("How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            Console.Write("Congrats on being " + age);
            Console.WriteLine(" !");
            Console.WriteLine();
            Console.Clear();
            Console.Write("Mind me asking how much you make at " + age);
            Console.Write(", " + username);
            Console.WriteLine("?");
            Console.WriteLine("(Please add a dollar and cent amount. Ex 13.50)");
            wage = Convert.ToDouble(Console.ReadLine());
            //Int32.TryParse(Console.ReadLine(), out age);
            Console.Write("Woah you make " + wage.ToString("C"));
            Console.Write(" at ");
            Console.WriteLine( age + "?");
            Console.WriteLine("I hope that's per hour and not per day. Good on you regardless, " + username);
        }
        //Console.WriteLine("User inputs ");
        public static void Part2()
        {
            
        }
    }
}
    
    

