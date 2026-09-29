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
        //Console.WriteLine("User inputs name");
        public static void Part1()
        {
            string username;
            Console.Write("I am Program.cs. What is your name? (PLEASE INPUT NAME): ");
            username = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();

            Console.Write("What's up, " + username);
            Console.WriteLine("?");
        }
        //Console.WriteLine("User inputs age");
        public static void Part2()
        {
            int age;
            Console.WriteLine();
            Console.WriteLine("How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            Console.Write("Congrats on being " + age);
            Console.WriteLine(" bro.");
            Console.ReadLine();
        }
    }
}
    
    

