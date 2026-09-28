namespace Topic_4_User_Input_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
        }
        //Console.WriteLine("Assignment by Easton Powers");
        //Console.WriteLine("User inputs name");
        public static void Part1()
            {
            string username;
            Console.Write("I am Program.cs. What is your name? (PLEASE INPUT NAME): ");
            username = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Hello " + username);
            Console.WriteLine(" How old are you?");
            }
        }
}
    

